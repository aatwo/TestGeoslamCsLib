using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeoslamCsLib
{
    public class PrintCommands
    {
        public static void PrintGreeting()
        {
            Console.WriteLine("Hello world :)");
        }

        public static void PrintSum(int a, int b)
        {
            Console.WriteLine(string.Format("{0}", a + b));
        }

        public static void PrintProduct(int a, int b)
        {
            Console.WriteLine(string.Format("{0}", a * b));
        }

        public static void PrintGoodbye()
        {
            Console.WriteLine("Goodbye world :(");
        }
    }
}
