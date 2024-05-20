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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Condor_Viajero
{
    public partial class Frm_Mapa : Form
    {
        Servicio servicio;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay = new GMapOverlay("Marker");

        bool trazarRuta = false;
        PointLatLng MiUbi;
        DataTable dtparaMisRutas = new DataTable();
        DataTable dtparaLugares = new DataTable();

        public string info;
        int filaSeleccionada = 0, cont = 0;
        PointLatLng Valledupar = new PointLatLng(10.469542991069783, -73.25712765309014), Lugar;
        List<PointLatLng> paradas = new List<PointLatLng>();
        List<PointLatLng> rutasTemporal = new List<PointLatLng>();
        List<PointLatLng> puntosAnteriores = new List<PointLatLng>();

        Bitmap flecha = Properties.Resources.arrow;
        Bitmap Estacion = Properties.Resources.estacion;
        private Frm_Carta carta;

        public Frm_Mapa()
        {
            InitializeComponent();
            servicio = new Servicio();
        }

        private void Mapa_Load(object sender, EventArgs e)
        {
            Mapa.MapProvider = BingMapProvider.Instance;
             BingMapProvider.Instance.ClientKey = servicio.BingMapApiKey;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            Mapa.Position = Valledupar;

            Mapa.ShowCenter = false;
            Mapa.AutoScroll = true;
            Mapa.CanDragMap = true;
            Mapa.DragButton = MouseButtons.Left;
            Mapa.MinZoom = 0; Mapa.MaxZoom = 50; Mapa.Zoom = 13;

            MiUbicacion();
            Paradas();
            Refrescar();

            //Mapa.OnMarkerClick += Mapa_OnMarkerClick;
        }

        //private void Mapa_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        //{
        //   if(e.Button == MouseButtons.Left)
        //    {
        //        if(carta == null || carta.IsDisposed)
        //        {
        //            carta = new Frm_Carta();
        //        }

        //        carta.FormBorderStyle = FormBorderStyle.FixedDialog;
        //        var UbicacionCarta = Mapa.PointToScreen(new System.Drawing.Point(e.X, e.Y));
        //        UbicacionCarta = new System.Drawing.Point(UbicacionCarta.X+2, UbicacionCarta.Y+2);
                
        //        carta.Location = UbicacionCarta;
        //        carta.Show();
        //    }
        //}

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
                dtGLugares.DataSource = dtparaLugares;
                dtGLugares.Columns["Latitud"].Visible = false;
                dtGLugares.Columns["Longitud"].Visible = false;
                LimpiarCajas();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            dtGLugares.Rows.RemoveAt(filaSeleccionada);
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
            DibujarMarcador(Lugar, "Punto",0,flecha);

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

            if (rutasTemporal.Count >= 2) CrearDireccionRuta(rutasTemporal[rutasTemporal.Count - 2], Lugar);
            cont++;
        }

        private void dtLugares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            TxtDescripcion.Text = dtGLugares.Rows[filaSeleccionada].Cells[0].Value.ToString();
            TxtLatitud.Text = dtGLugares.Rows[filaSeleccionada].Cells[1].Value.ToString();
            TxtLongitud.Text = dtGLugares.Rows[filaSeleccionada].Cells[2].Value.ToString();

            marker.Position = new PointLatLng(Convert.ToDouble(TxtLatitud.Text), Convert.ToDouble(TxtLongitud.Text));
            Mapa.Position = marker.Position;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Frm_Emergente E1 = new Frm_Emergente();
            E1.ShowDialog();
            string NombreRuta = E1.info;

            LimpiarMapa();

            if (dtparaMisRutas.Columns.Count == 0)
            {
                dtparaMisRutas.Columns.Add("Nombre", typeof(string));
                dtparaMisRutas.Columns.Add("Ruta", typeof(List<PointLatLng>));
            }

            List<PointLatLng> rutaGuardar = new List<PointLatLng>(rutasTemporal);
            dtparaMisRutas.Rows.Add(NombreRuta, rutaGuardar);
            dtGMisRutas.DataSource = dtparaMisRutas;
            rutasTemporal.Clear();
            cont = 0;
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
            PointLatLng ParadaLejos = new PointLatLng(10.489331020207, -73.2707405090332);

            paradas.Add(lasFloresParada);
            paradas.Add(ParadaLejos);


            DibujarMarcador(ParadaLejos, "Parada upc",0,Estacion);
            DibujarMarcador(lasFloresParada, "Parada las flores",0,Estacion);

            Figureradio(lasFloresParada);
            Figureradio(ParadaLejos);
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

        
        private void DatosRutaSiva_CellContentClick(object sender, DataGridViewCellEventArgs e)//To-do: Meter rutas y paraderos en este metodo;
        {
            //PointLatLng UPC = new PointLatLng(10.450966534822214, -73.26093002209686); //Universidad Popular del Cesar
            //PointLatLng MDA = new PointLatLng(10.47908708002588, -73.25978628647384); //Museo del Acordeón
            //PointLatLng MSM = new PointLatLng(10.48989010513216, -73.27257498887771); //Makro Supermayorista
            //PointLatLng PIracal = new PointLatLng(10.474402730802199, -73.26789672708824); //Parque Iracal
            //PointLatLng DBB = new PointLatLng(10.463335690167154, -73.27581516847924); //Decima Brigada Blindada
            //bool irAPie = false;

            //List<PointLatLng> sitios = new List<PointLatLng>() { UPC, MDA, MSM, PIracal, DBB };
            //GMapMarker marcador1 = new GMarkerGoogle(UPC, Estacion);
            //GMapMarker marcador2 = new GMarkerGoogle(MDA, Estacion);
            //GMapMarker marcador3 = new GMarkerGoogle(MSM, Estacion);
            //GMapMarker marcador4 = new GMarkerGoogle(PIracal, Estacion);
            //GMapMarker marcador5 = new GMarkerGoogle(DBB, Estacion);

            //markerOverlay.Markers.Add(marcador1);
            //markerOverlay.Markers.Add(marcador2);
            //markerOverlay.Markers.Add(marcador3);
            //markerOverlay.Markers.Add(marcador4);
            //markerOverlay.Markers.Add(marcador5);

            //Mapa.Overlays.Add(markerOverlay);
            //Mapa.Overlays.Add(Sitios_a_Visitar(sitios, irAPie));
            //Mapa.Position = marker.Position;
            MessageBox.Show("Calmate, esta en construccion");
        }

        private void CrearDireccionRuta(PointLatLng ini, PointLatLng fin)
        {
            if (trazarRuta == true)
            {
                List<PointLatLng> RutaDibujar = new List<PointLatLng>() { ini,fin};
                DibujarRuta(RutaDibujar);
                trazarRuta = false;
                LlegarBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se puede trazar una ruta en este momento");
            }
        }

        private void DibujarRuta(List<PointLatLng> ruta)
        {
            GMapOverlay Ruta = new GMapOverlay("Capa de la ruta");
            MapRoute DireccionRuta = BingMapProvider.Instance.GetRoute(ruta, false, false, 15);

            if (Ruta != null || DireccionRuta != null)
            {
                    GMapRoute RutaObtenida = new GMapRoute(DireccionRuta.Points, "RutasGuardar");
                    RutaObtenida.Stroke = new Pen(Color.Aquamarine);
                    RutaObtenida.Stroke.Width = 5;
                    Ruta.Routes.Add(RutaObtenida);
                    Mapa.Overlays.Add(Ruta);
                    Refrescar();
            }
            else
            {
                MessageBox.Show("No se pudo trazar la ruta");
                LimpiarMapa();
            }
        }

        private void dtGMisRutas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                List<PointLatLng> rutaRecuperada = (List<PointLatLng>)dtparaMisRutas.Rows[e.RowIndex]["Ruta"];
                DibujarRuta(rutaRecuperada);
                
                foreach(var marcador in rutaRecuperada)
                {
                    DibujarMarcador(marcador, "Lugar", 0, flecha);
                }
            }
        }



        public void MiUbicacion()
        {
            Bitmap UbicacionUser = Properties.Resources.user_lot;
            GeoCoordinateWatcher Gwatcher = new GeoCoordinateWatcher();
            Gwatcher.PositionChanged += (oS, e) => {
                var coordinate = e.Position.Location;

                MiUbi = new PointLatLng(coordinate.Latitude, coordinate.Longitude);

                DibujarMarcador(MiUbi, "Mi ubicacion",0,UbicacionUser);
                Figureradio(MiUbi);
                servicio.CalcularDistancia(MiUbi);
            };
            Gwatcher.Start();
        }

        private void LimpiarMapa()
        {
            foreach (var item in Mapa.Overlays.AsEnumerable<GMapOverlay>())
            {
                item.Routes.Clear();
                markerOverlay.Markers.Clear();
            }
        }


    }
}
