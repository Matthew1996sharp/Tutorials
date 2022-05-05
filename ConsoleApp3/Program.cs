using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteHello("Hello, World!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Multiply(num1, num2);
            Console.WriteLine("Result = " + result);
            Console.ReadKey();
        }

        public static void WriteHello(string str)
        {
            Console.WriteLine(str);
        }

        public static int Multiply(int num1, int num2)
        {
            return( num1 * num2);
        }
    }
}
