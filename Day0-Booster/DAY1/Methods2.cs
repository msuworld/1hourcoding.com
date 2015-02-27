using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class Methods2
    {
        static double Readvalue(string prompt, double low, double high)
        {
            double result = 0;

            do
            {
                Console.WriteLine(prompt + "Between" + low + "and" + high);
                string resultstring = Console.ReadLine();
                result = double.Parse(resultstring);
            } while ((result < low) || (result > high));
            return result;
        }

        static void _Main()
        {
            const double MIN_WIDTH=55;
            const double MAX_WIDTH=170;
           // double windowWidth = Readvalue("Enter the Width of the Window:", MIN_WIDTH, MAX_WIDTH);
            double value = Readvalue("Enter Your age:", 0, 70);
            Console.ReadKey();
        }
    }
}
