using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housesExample
{
    class Program
    {
        static void Main(string[] args)
        {
         //   House house1 = new House();                 //how to call from class

          //  house1.Paint("Green");
           // Console.WriteLine(house1.CurrentColor());

          //  house1.Paint("White");
          //  Console.WriteLine(house1.CurrentColor());

         //   House house2 = new House();
         //   house2.Paint("Blue");

         //   Console.WriteLine("house one is: " + house1.CurrentColor());
         //   Console.WriteLine("house two is: " + house2.CurrentColor());

            House house1 = new House("Green", 4, 1000, 3);
            house1.DisplayHouseInfo();


        }
    }
}
