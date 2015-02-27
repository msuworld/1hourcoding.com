using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class moreGlassWidth
    {
        private static void _Main()
        {
            double width, height, woodLength, glassArea;
            const double MAX_WIDTH = 5;
            const double MIN_WIDTH=1;
            const double MAX_HEIGHT=20;
            const double MIN_HEIGHT=2;

            do
            {
                Console.WriteLine("Please Enter glass width between" + MAX_WIDTH + " and" + MIN_WIDTH+":");
                string widthString = Console.ReadLine();
                width = double.Parse(widthString);
            } while (width < MIN_WIDTH || width > MAX_WIDTH);
            do
            {
                Console.WriteLine("Please Enter Glass Height Between" + MAX_HEIGHT + "and" + MIN_HEIGHT);
                string heigthString = Console.ReadLine();
                height = double.Parse(heigthString);

            } while (height < MIN_HEIGHT || height > MAX_HEIGHT);

            woodLength = (width*height)*3.25;
            glassArea = width*height;

            Console.WriteLine("Woodlength is "+woodLength);
            Console.WriteLine("glass Area is"+glassArea);
            Console.ReadKey();
        }

    }
}
