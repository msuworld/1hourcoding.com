using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    class LibraryofMethods
    {
        static string readstring(string prompt)
        {
            string result;
            do{
                Console.Write(prompt);
                result = Console.ReadLine();
            } while (result=="");
            return result;
        }
        static int readint(string prompt,int low, int high)
        {
            int result;
            do
            {
                string intstring;
                intstring = readstring(prompt);
                result = int.Parse(intstring);
            } while ((result < low) || (result > high));
            return result;
        }

        static void Main()
        {
            string name;
            name = readstring("Enter Your Name");
            int age;
            age = readint("Enter Your Age", 0, 100);
            Console.ReadKey();
        }
    }
}
