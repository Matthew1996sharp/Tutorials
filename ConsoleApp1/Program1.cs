using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 5; i /= 2)
            {
                if (i < 8) break;
                Console.WriteLine(i);
            }

            int n = 50;
            while (n > 60)
            {
                Console.WriteLine(n);
                n /= 5;
            }

            int number;
            do
            {
                Console.WriteLine("Enter number");
                number = Convert.ToInt32(Console.ReadLine());
            } while (number != 5);
        }
    }
}
