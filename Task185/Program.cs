using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task185
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 2, 13, 3, 34, 5 };
            int counter = 0;
            int max = array.Max();

            for (int i = 1; i < array.Length-1; i++)
            {
                if (Math.Pow(array[i - 1], 2) + Math.Pow(array[i + 1], 2) == array[i] && array[i]!=max) counter++;
            }

            Console.WriteLine("Количество чисел:");
            Console.WriteLine(counter);

            Console.Read();
        }
    }
}
