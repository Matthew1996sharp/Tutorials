using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 24;
            array[1] = 4;
            array[2] = 2;
            array[3] = 57;
            array[4] = 56;
            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);

            string[] names = new string[3] {"Tom", "John", "George"};
            for (int i = 0; i <names.Length; i++) Console.WriteLine(names[i]);

            List<int> numbers = new List<int>();
            numbers.Add(23);
            numbers.Add(56);
            Console.WriteLine(numbers[1]);
            for (int i = 0; i < numbers.Count; i++) Console.Write(numbers[i]);
            numbers.RemoveAt(0);
            numbers.Remove(56);

            int length = 10;
            int[,] numbers1 = new int[length, length];

            for (int i = 0; i < numbers1.Length; i++)
                for (int j = 0; i < numbers1.Length; i++)
                {
                    numbers1[i, j] = i + j;
                    Console.Write(numbers1[i, j] + " ");
                }

            float[] numbers2 = { 1.23f, 23.23f, 23.57f };
            foreach (float el in numbers2) Console.WriteLine(el);
            Console.ReadKey();
        }
    }
}
