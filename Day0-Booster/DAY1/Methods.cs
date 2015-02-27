using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class Methods
    {
        static int sillyReturn(int i)
        {
            i = i + 1;
            Console.WriteLine("i is "+i);
            return i;
        }
       
        public static void _Main()
        {
            int res;
            res = sillyReturn(5)+ sillyReturn(7)+1;
           
            Console.WriteLine("res is: "+res);
            sillyReturn(5);
            Console.ReadKey();
        }
    }
}
