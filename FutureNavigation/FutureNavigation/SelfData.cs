using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureNavigation
{
    public class SelfData
    {
        private const double g = 9.8;// m/s^2

        private double rollAngle;//זווית גלגול
        private double Vt;// היטל מהירות קרקעית //לבדוק אם אני מקבל את זה מהמטוס או מחשב כמו שהם מראים
        private double rateOfTurn;//קצב הפנייה
        private double TrueSpeed;// מהירות אמיתית של המטוס
        private double h;//קצב הטיפוס
        private double r;//ההעתק הקרקעי כתוצאה מהרוח
        private int vWind;//מהירות הרוח
        private int t;//זמן השערוך
        private double airCraftAsimut;
        private double windAsimut;
        private double Theta;//זווית ביוהרוח ביחס לצירי המטוס 
        private double R;
        private double beta;//turninig circle angle //זווית מעגל הפנייה 
    }
}
