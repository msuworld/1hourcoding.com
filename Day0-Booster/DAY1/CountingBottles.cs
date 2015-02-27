using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class CountingBottles
    {
        private static void _Main()
        {
            int bottlecount, salesprice;
            string pricePerBottleString = Console.ReadLine();
            int pricePerBottle = int.Parse(pricePerBottleString);
            string tabletCountString = Console.ReadLine();
            int tabletCount = int.Parse(tabletCountString);

            bottlecount = ((tabletCount + 99) / 100);
            salesprice = bottlecount * pricePerBottle;

            Console.WriteLine("Total Number of Bottles" + bottlecount);
            Console.WriteLine("Total Price is " + salesprice);
            Console.ReadKey();
        }



    }
}
