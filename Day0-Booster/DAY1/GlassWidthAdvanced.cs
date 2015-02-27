using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class GlassWidthAdvanced
    {
        static void _Main()
        {
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 5;
            const double MIN_WIDTH = 0.5;
            const double MAX_HEIGHT = 5;
            const double MIN_HEIGHT = 0.2;
            
            Console.Write("Give the Width of the Glass");
            string widthString = Console.ReadLine();
            width = double.Parse(widthString);
            if (width < MIN_WIDTH)
            {
                Console.WriteLine("Width is too small.\n\n");
                Console.WriteLine("Using Minimum");
                width = MIN_WIDTH;
            }
            if (width > MAX_WIDTH)
            {
                Console.WriteLine("Width is very Big.\n\n");
                Console.WriteLine("Using Maximum");
                width = MAX_WIDTH;
            }

           Console.Write("Give Height of the Glass ");
            string heightString = Console.ReadLine();
            height = double.Parse(heightString);
            if (height < MIN_HEIGHT)
            {
                Console.WriteLine("Height is too short.\n\n");
                Console.WriteLine("Using Minimum");
                height = MIN_HEIGHT;
            }
            if (height > MAX_HEIGHT)
            {
                Console.WriteLine("Height is too big.\n\n");
                Console.WriteLine("Using Maximum");
                height = MAX_HEIGHT;
            }

            woodLength = 2*(width + height)*3.25;
            glassArea = 2*(width + height);

            Console.WriteLine("The Length of the Area is "+woodLength+"Feet");
            Console.WriteLine("The Area of the Glass is"+glassArea+"Square meters");

            Console.ReadKey();

        }
    }
}
