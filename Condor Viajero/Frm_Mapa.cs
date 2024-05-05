using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace Condor_Viajero
{
    public partial class Frm_Mapa : Form
    {
        public Frm_Mapa()
        {
            InitializeComponent();
        }

        private void Frm_Mapa_Load(object sender, EventArgs e)
        {
            PointLatLng Valledupar = new PointLatLng(10.46776216807525, -73.25654892844787);

            Mapa.MapProvider = OpenStreetMapProvider.Instance;
            BingMapProvider.Instance.ClientKey = @"ApUTaO7sHvGZqA6QHbqWc3xCLF7i6InJfoCThewaS9kbjCASLhy2gCnU2QvNI2SA";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            Mapa.Position = Valledupar;
            Mapa.DragButton = MouseButtons.Left;
            Mapa.MinZoom = 12; Mapa.MaxZoom = 18; Mapa.Zoom = 13;
        }
    }
}
