using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureNavigation
{
    public class MyExtention
    {
        public GeoCoordinate[] CombineArr()
        {
            GeoCoordinate[] FutureNoodle = new GeoCoordinate[30];
            var windArr =new WindCalculation().points;
            var noWindArr = new Calculation().points;
            for (int i = 0; i < windArr.Length; i++)
            {
                FutureNoodle[i] = new GeoCoordinate(windArr[i].Latitude + noWindArr[i].Latitude,
                    windArr[i].Longitude + noWindArr[i].Longitude);
            }
            return FutureNoodle;
        }
    }
}
