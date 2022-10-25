using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureNavigation
{
    public class GeoCoordinate
    {
        public GeoCoordinate() { }
        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; }//y
        public double Longitude { get; set; }//x
    }
}
