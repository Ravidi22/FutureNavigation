using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureNavigation
{
    public class Calculation
    {
        public GeoCoordinate[] points = new GeoCoordinate[30];
        private const double g = 9.8;// m/s^2

        ///////////////////////////////////////////////////////////////Calc  
        private double R;
        private double Beta; //זווית מעגל פנייה 

        ///////////////////////////////////////////////////////////////SMPI
        private int GroundSpeed;
        private double RollAngle;
        private double RateOfTurn; //קצב הפנייה

        public  Calculation()
        {
            GetData();
            R = Math.Pow(GroundSpeed, 2) / (g * Math.Tan(RollAngle));
            for (int i = 0, t = 0; i < points.Length; i++, t += 2)
            {
                //if (CheckTurn())//if the plane go in straight line 
                //{
                //    points[i] = new GeoCoordinate(R, 0);
                //    break;
                //}
                Beta = Math.Abs(RateOfTurn * t);
                points[i] = new GeoCoordinate(R * Math.Sin(Beta), Math.Sin(RollAngle) * R * (1 - Math.Cos(Beta)));
            }
        }
        
        public bool CheckTurn()
        {
            return true;//the calc need to be with the diffarence of -asimut/direction 
        }
        public void GetData()// just placing values
        {
            GroundSpeed = 500;
            RollAngle = 30;
            RateOfTurn = 10;
        }


    }
}
