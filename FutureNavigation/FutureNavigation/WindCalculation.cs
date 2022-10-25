using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureNavigation
{
    public class WindCalculation
    {
        public GeoCoordinate[] points = new GeoCoordinate[30];

        ///////////////////////////////////////////////////////////////Calc  
        private double r;//ההעתק הקרקעי כתוצאה מהרוח
        private double Theta;//זווית ביוהרוח ביחס לצירי המטוס 
        private double Vt;//היטל מהירות קרקעית על פני האופק

        ///////////////////////////////////////////////////////////////SMPI
        private double h;//קצב הטיפוס
        private int vWind;//מהירות הרוח
        private int t;//זמן השערוך
        private int TrueSpeed;
        private double airCraftAsimut;
        private double windAsimut;
       
        public WindCalculation()
        {
            GetData();
            for (int i = 0; i < points.Length; i++)// some value has to change, should i run /increase until t with++ or what???
            {
                r = Math.Abs(vWind) * t;
                Theta = airCraftAsimut - windAsimut + 180;
                Vt = Math.Sqrt(Math.Pow(TrueSpeed, 2) - Math.Pow(h, 2));
                points[i] = new GeoCoordinate(r * Math.Cos(Theta), -r * Math.Sin(Theta));
            }
        }
        public void GetData()// just placing values
        {
            h = 10;
            vWind = 30;
            t = 10;
            TrueSpeed = 700;
            airCraftAsimut = 30;
            windAsimut = 40;
        }

    }
}
  

