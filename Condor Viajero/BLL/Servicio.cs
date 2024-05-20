using System;
using System.Collections.Generic;
using System.Linq;
using GMap.NET;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Servicio
    {
        //Consumo API
        public string BingMapApiKey { get; } = @"ApUTaO7sHvGZqA6QHbqWc3xCLF7i6InJfoCThewaS9kbjCASLhy2gCnU2QvNI2SA";

        public List<PointLatLng> CalcularRadio(PointLatLng ubicacion)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            double distanciaRad = 0.050 / 6371;
            double angulo = 0;

            for (int i = 0; i <= 16; i++)
            {
                double latRadianes = GradosARadian(ubicacion.Lat);
                double logRadianes = GradosARadian(ubicacion.Lng);

                double anguloRad = GradosARadian(angulo);
                angulo += 22.5;

                double newLatitudRad = Math.Asin(Math.Sin(latRadianes) * Math.Cos(distanciaRad) +
                Math.Cos(distanciaRad) * Math.Sin(distanciaRad) * Math.Cos(anguloRad));

                double newLongitudRad = logRadianes + Math.Atan2(
                Math.Sin(anguloRad) * Math.Sin(distanciaRad) * Math.Cos(latRadianes),
                Math.Cos(distanciaRad) - Math.Sin(latRadianes) * Math.Sin(newLatitudRad));

                double Latfinal = RadianesAGrados(newLatitudRad);
                double Lngfinal = RadianesAGrados(newLongitudRad);

                points.Add(new PointLatLng(Latfinal, Lngfinal));
            }

            return points;
        }

        private double GradosARadian(double Valorgrados)
        {
            double Radianes = Valorgrados * Math.PI / 180;
            return Radianes;
        }

        private double RadianesAGrados(double ValorRadianes)
        {
            double Grados = ValorRadianes * 180 / Math.PI;
            return Grados;
        }

        public void CalcularDistancia(PointLatLng ubicacion, List<PointLatLng> puntos = null)
        {
            List<double> distancias = new List<double>();
            double Lat1 = GradosARadian(ubicacion.Lat);
            double Lng1 = GradosARadian(ubicacion.Lng);

            if (puntos != null)
            {
                foreach (var item in puntos)
                {
                    double Lat2 = GradosARadian(item.Lat);
                    double Lng2 = GradosARadian(item.Lng);

                    double distancia = 2 * 6371 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin((Lat2 - Lat1) / 2), 2) + Math.Cos(Lat1) * Math.Cos(Lat2) * Math.Pow(Math.Sin((Lng2 - Lng1) / 2), 2)));
                    distancias.Add(distancia);
                }

                double minimaDistancia = distancias.Min();
            }
        }
    }
}
