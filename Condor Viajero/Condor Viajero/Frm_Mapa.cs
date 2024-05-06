using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Device.Location;
using GMap.NET;
using GMap.NET.CacheProviders;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Spatial;
using System.Diagnostics;

namespace Condor_Viajero
{
    public partial class Frm_Mapa : Form
    {
        Servicio servicio;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay = new GMapOverlay("Marker"), Rutas;

        bool trazarRuta = false, guardarPunto = false;
        PointLatLng MiUbi;
        DataTable dtparaMisRutas = new DataTable();
        DataTable dtparaLugares = new DataTable();

        public string info;
        int filaSeleccionada = 0, cont = 0;
        PointLatLng Valledupar = new PointLatLng(10.469542991069783, -73.25712765309014), Lugar;
        List<PointLatLng> paradas = new List<PointLatLng>();
        List<PointLatLng> rutasTemporal = new List<PointLatLng>();
        List<PointLatLng> puntosAnteriores = new List<PointLatLng>();


        public Frm_Mapa()
        {
            InitializeComponent();
            servicio = new Servicio();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            Mapa.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            Mapa.Position = Valledupar;

            Mapa.DragButton = MouseButtons.Left;
            Mapa.MinZoom = 12; Mapa.MaxZoom = 15; Mapa.Zoom = 13;
            Mapa.Overlays.Add(markerOverlay);
            Mapa.MinZoom = 0;
            Mapa.MaxZoom = 50;
            Mapa.Zoom = 13;
            Mapa.AutoScroll = true;

            //Consumo
            Mapa.DragButton = MouseButtons.Left;
            Mapa.CanDragMap = true;
            Mapa.MapProvider = BingMapProvider.Instance;
            BingMapProvider.Instance.ClientKey = @"ApUTaO7sHvGZqA6QHbqWc3xCLF7i6InJfoCThewaS9kbjCASLhy2gCnU2QvNI2SA";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;


            //Metodos
            //RutaSiva();
            MiUbicacion();
            Paradas();
            Refrescar();
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Por favor inserte el nombre del punto");
                return;
            }
            else
            {
                if (dtparaLugares.Columns.Count == 0)
                {
                    dtparaLugares.Columns.Add("Lugares", typeof(string));
                    dtparaLugares.Columns.Add("Latitud", typeof(string));
                    dtparaLugares.Columns.Add("Longitud", typeof(string));
                }
                dtparaLugares.Rows.Add(TxtDescripcion.Text, TxtLatitud.Text, TxtLongitud.Text);
                dtLugares.DataSource = dtparaLugares;
                dtLugares.Columns["Latitud"].Visible = false;
                dtLugares.Columns["Longitud"].Visible = false;
                LimpiarCajas();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            dtLugares.Rows.RemoveAt(filaSeleccionada);
            Refrescar();
            LimpiarCajas();
            Mapa.Position = Valledupar;
        }

        private void LlegarBtn_Click(object sender, EventArgs e)
        {
            trazarRuta = true;
            LlegarBtn.Enabled = false;
        }

        private void Mapa_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double Lat = Mapa.FromLocalToLatLng(e.X, e.Y).Lat;
            double Lng = Mapa.FromLocalToLatLng(e.X, e.Y).Lng;
            puntosAnteriores.Add(new PointLatLng(Lat, Lng));

            Lugar = new PointLatLng(Lat, Lng);
            TxtLatitud.Text = Lat.ToString();
            TxtLongitud.Text = Lng.ToString();
            DibujarMarcador(Lugar, "Punto", GMarkerGoogleType.black_small);

            if (trazarRuta == true)
            {
                if (cont == 0)
                {
                    rutasTemporal.Add(MiUbi);
                    rutasTemporal.Add(Lugar);
                }
                else
                {
                    rutasTemporal.Add(puntosAnteriores[puntosAnteriores.Count - 2]);
                    rutasTemporal.Add(Lugar);
                }
            }

            if (rutasTemporal.Count >= 2) CrearDireccionTrazarRuta(rutasTemporal[rutasTemporal.Count - 2], Lugar);
            cont++;
        }

        private void dtLugares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            TxtDescripcion.Text = dtLugares.Rows[filaSeleccionada].Cells[0].Value.ToString();
            TxtLatitud.Text = dtLugares.Rows[filaSeleccionada].Cells[1].Value.ToString();
            TxtLongitud.Text = dtLugares.Rows[filaSeleccionada].Cells[2].Value.ToString();

            marker.Position = new PointLatLng(Convert.ToDouble(TxtLatitud.Text), Convert.ToDouble(TxtLongitud.Text));
            Mapa.Position = marker.Position;
        }

        private void DatosRutaSiva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PointLatLng UPC = new PointLatLng(10.450966534822214, -73.26093002209686); //Universidad Popular del Cesar
            PointLatLng MDA = new PointLatLng(10.47908708002588, -73.25978628647384); //Museo del Acordeón
            PointLatLng MSM = new PointLatLng(10.48989010513216, -73.27257498887771); //Makro Supermayorista
            PointLatLng PIracal = new PointLatLng(10.474402730802199, -73.26789672708824); //Parque Iracal
            PointLatLng DBB = new PointLatLng(10.463335690167154, -73.27581516847924); //Decima Brigada Blindada
            //bool irAPie = false;
            Bitmap BusParada = (Bitmap)Image.FromFile("C://Users//57304//source//repos//Condor_Viajero//Condor Viajero//IMG//estacion.png");

            List<PointLatLng> sitios = new List<PointLatLng>() { UPC, MDA, MSM, PIracal, DBB };
            GMapMarker marcador1 = new GMarkerGoogle(UPC, BusParada);
            GMapMarker marcador2 = new GMarkerGoogle(MDA, BusParada);
            GMapMarker marcador3 = new GMarkerGoogle(MSM, BusParada);
            GMapMarker marcador4 = new GMarkerGoogle(PIracal, BusParada);
            GMapMarker marcador5 = new GMarkerGoogle(DBB, BusParada);

            markerOverlay.Markers.Add(marcador1);
            markerOverlay.Markers.Add(marcador2);
            markerOverlay.Markers.Add(marcador3);
            markerOverlay.Markers.Add(marcador4);
            markerOverlay.Markers.Add(marcador5);

            Mapa.Overlays.Add(markerOverlay);
            //Mapa.Overlays.Add(Sitios_a_Visitar(sitios, irAPie));
            Mapa.Position = marker.Position;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Frm_Emergente E1 = new Frm_Emergente();
            E1.ShowDialog();
            string name = E1.info;

            foreach (var item in Mapa.Overlays.AsEnumerable<GMapOverlay>())
            {
                item.Routes.Clear();
                markerOverlay.Markers.Clear();
            }

            if (dtMisRutas.Columns.Count == 0)
            {
                dtMisRutas.Columns.Add("0", "Nombre");
                dtMisRutas.Columns.Add("1", "Ruta");
            }

            List<PointLatLng> rutaGuardar = new List<PointLatLng>(rutasTemporal);
            dtMisRutas.Rows.Add(name, rutaGuardar);
            rutasTemporal.Clear();
            cont = 0;
        }

        private void dtMisRutas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {

                List<PointLatLng> ListaRecuperada = (List<PointLatLng>)dtMisRutas.Rows[e.RowIndex].Cells[1].Value;
                if (ListaRecuperada != null && ListaRecuperada.Count > 0)
                {
                    DibujarRuta(ListaRecuperada);
                    foreach (var item in ListaRecuperada)
                    {
                        DibujarMarcador(item, "Lugar", GMarkerGoogleType.black_small);
                    }
                }
                else
                {
                    MessageBox.Show("La lista de puntos está vacía.");
                }
            }
        }



        //METODOS
        private void LimpiarCajas()
        {
            TxtDescripcion.Text = string.Empty;
            TxtLatitud.Text = string.Empty;
            TxtLongitud.Text = string.Empty;
        }

        private void Refrescar()
        {
            Mapa.Zoom = Mapa.Zoom + 1;
            Mapa.Zoom = Mapa.Zoom - 1;
        }

        private void Figureradio(PointLatLng puntoCentral)
        {
            List<PointLatLng> points = servicio.CalcularRadio(puntoCentral);

            markerOverlay = new GMapOverlay();
            GMapRoute fig = new GMapRoute(points, "radio");
            markerOverlay.Routes.Add(fig);
            Mapa.Overlays.Add(markerOverlay);
            Refrescar();
        }

        private void Paradas()
        {
            PointLatLng lasFloresParada = new PointLatLng(10.469994, -73.257306);
            PointLatLng UpcParada = new PointLatLng(10.450651, -73.26183);

            paradas.Add(lasFloresParada);
            paradas.Add(UpcParada);


            DibujarMarcador(UpcParada, "Parada upc", GMarkerGoogleType.black_small);
            DibujarMarcador(lasFloresParada, "Parada las flores", GMarkerGoogleType.black_small);

            Figureradio(lasFloresParada);
            Figureradio(UpcParada);
        }

        private void DibujarMarcador(PointLatLng ubicacion, string description, GMarkerGoogleType arrow = 0, Bitmap Img = null)
        {
            if (arrow == 0)
            {
                marker = new GMarkerGoogle(ubicacion, Img);
            }
            else
            {
                marker = new GMarkerGoogle(ubicacion, arrow);
            }

            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTipText = string.Format($"{description}: \n Latitud{ubicacion.Lat} \n Longitud {ubicacion.Lng}");
            markerOverlay.Markers.Add(marker);
            Mapa.Overlays.Add(markerOverlay);
            Refrescar();
        }

        private void DibujarRuta(List<PointLatLng> ruta)
        {
            Rutas = new GMapOverlay("Capa de la ruta");
            MapRoute Ruta = BingMapProvider.Instance.GetRoute(ruta, false, false, 15);

            if (Ruta != null)
            {
                GMapRoute RutaObtenida = new GMapRoute(Ruta.Points, "RutasGuardar");
                RutaObtenida.Stroke = new Pen(Color.Orange);
                RutaObtenida.Stroke.Width = 3;
                Rutas.Routes.Add(RutaObtenida);
                Mapa.Overlays.Add(Rutas);
                Refrescar();
            }
            else
            {
                MessageBox.Show("No se pudo trazar la ruta");
            }
        }


        private void CrearDireccionTrazarRuta(PointLatLng ini, PointLatLng fin)
        {
            if (trazarRuta == true)
            {
                List<PointLatLng> RutaDibujar = new List<PointLatLng>();
                RutaDibujar.Add(ini);
                RutaDibujar.Add(fin);
                DibujarRuta(RutaDibujar);
                trazarRuta = false;
                LlegarBtn.Enabled = true;
            }
        }


        public void MiUbicacion()
        {
            GeoCoordinateWatcher Gwatcher = new GeoCoordinateWatcher();
            Gwatcher.PositionChanged += (oS, e) => {
                var coordinate = e.Position.Location;

                MiUbi = new PointLatLng(coordinate.Latitude, coordinate.Longitude);

                DibujarMarcador(MiUbi, "Mi ubicacion", GMarkerGoogleType.black_small);
                Figureradio(MiUbi);
                servicio.CalcularDistancia(MiUbi);
            };
            Gwatcher.Start();

        }


        //private MapRoute TrazarRuta(PointLatLng inicio, PointLatLng final, bool evitarAutopistas, bool modoCaminata, int zoom)
        //{
        //    MapRoute ruta = BingMapProvider.Instance.GetRoute(inicio, final, evitarAutopistas, modoCaminata, 15);
        //    return ruta;
        //    GMapOverlay rutas = new GMapOverlay("Rutas");
        //    MapRoute ruta;
        //    GMapRoute r;

        //    for (int i = 0; i < sitios.Count; i++)
        //    {
        //        if (i != (sitios.Count - 1))
        //        {
        //            ruta = BingMapProvider.Instance.GetRoute(sitios[i], sitios[i + 1], false, irAPie, 15);
        //        }
        //        else
        //        {
        //            ruta = BingMapProvider.Instance.GetRoute(sitios[i], sitios[0], false, irAPie, 15);
        //        }

        //        r = new GMapRoute(ruta.Points, "Agregando la RutasGuardar");
        //        r.Stroke.Wih = 2;
        //        r.Stroke.Color = Color.SeaGreen;
        //        rutas.Routes.Add(r);
        //    }
        //    return rutas;
        //}

    }
}
