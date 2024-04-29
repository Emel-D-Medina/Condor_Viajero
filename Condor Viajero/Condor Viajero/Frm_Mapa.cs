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
using GMap.NET.CacheProviders;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace Condor_Viajero
{
    public partial class Frm_Mapa : Form
    {
        PointLatLng Valledupar = new PointLatLng(10.469542991069783, -73.25712765309014);

        public Frm_Mapa()
        {
            InitializeComponent();
            Mapa.MapProvider = OpenStreetMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            BingMapProvider.Instance.ClientKey = Cls_ApiKey.BingMapApiKey;
            Mapa.Position = Valledupar;
            Mapa.DragButton = MouseButtons.Left;
            Mapa.MinZoom = 12; Mapa.MaxZoom = 18; Mapa.Zoom = 13;
        }
    }
}
