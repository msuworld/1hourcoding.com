using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class Glasswidth
    {
        static void _Main(string[] args)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2*(width + height)*3.25;
            glassArea = 2*(width*height);

            Console.WriteLine("The Length of the Wood is "+woodLength+"feet");
            Console.ReadKey();

            Console.WriteLine("The Area of the Glass is "+ glassArea+"Square meteres");

            Console.ReadKey();







        }
    }
}
