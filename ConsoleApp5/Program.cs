using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number = " + number);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception");
            }
            Console.ReadKey();
        }
    }
}
