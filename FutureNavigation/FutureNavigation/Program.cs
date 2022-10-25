using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureNavigation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var FutureNoodle= new MyExtention().CombineArr();
            for (int i = 0; i < FutureNoodle.Length; i++)
            {
                Console.WriteLine(FutureNoodle[i].Longitude+ " , " + FutureNoodle[i].Latitude);
            }
            
            for (int i = 0; i < 30; i++)// just check and prove somthing in wind calc need to change cause it all the same parmeters and same result
            {
                Console.WriteLine(" wind ");
                var arr = new WindCalculation().points;
                Console.WriteLine(arr[i].Longitude + " , " + arr[i].Latitude);
            }
            Console.ReadLine();
        }
    }
}
