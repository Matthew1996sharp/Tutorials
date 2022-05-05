using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello!";
            Console.WriteLine(str[1]);
            Console.WriteLine(str.Length);
            Console.WriteLine(String.IsNullOrEmpty(str));
            Console.WriteLine(String.IsNullOrWhiteSpace(str));
            string.Compare("a", "b");
            string strextra = "Hello, World!";
            Console.WriteLine(strextra.ToUpper());
            Console.WriteLine(strextra.ToLower());
            Console.WriteLine(strextra.Contains('H'));
            Console.WriteLine(strextra.StartsWith("H"));
            Console.WriteLine(strextra.EndsWith("d"));
            Console.WriteLine(strextra.Insert(5, "H"));
            Console.WriteLine(strextra.Remove(5));
            Console.WriteLine(strextra.Replace("W", "w"));
            char[] sym = strextra.ToCharArray();

            string str1 = "Arsenal, Dynamo, Real";
            string[] clubs = str1.Split(', ');
            Console.WriteLine(clubs[1]);

            Console.ReadKey();
        }
    }
}
