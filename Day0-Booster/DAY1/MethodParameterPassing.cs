using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class MethodParameterPassing
    {
        //Parameter Passing By Value 
        static void addOneToParam(int i)
        {
            i = i + 1;
            Console.WriteLine("i is"+i);

        }
        //Passing Parameters via References changes the value of the  variable in the method too
        static void addOneToParam1(ref int i)
        {
            i = i + 1;
            Console.WriteLine("i is"+i);
        }

        static void _Main()
        {
            int test = 20;
            //addOneToParam(test);
            //addOneToParam(test + 100);
            addOneToParam1(ref test);
            Console.WriteLine("Test is" + test);

            Console.ReadKey();
        }


    }
}
