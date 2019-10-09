using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task176
{
    class Program
    {
        static int count;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите число повторений:");
            count = int.Parse(Console.ReadLine());
            var strArr = str.Split(' ');

            Repeater(strArr);

            Console.ReadKey();

        }

        public static void Repeater(string[] str, int startPosition=0, int counter = 1)
        {
            if (startPosition >= str.Length) return;
            if (counter-1 == count) counter = 1;
            int range = startPosition + counter > str.Length ? str.Length : startPosition + counter;

            for (int i = startPosition; i < range; i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();

            startPosition += counter;
            counter++;

            Repeater(str, startPosition, counter);
        }
    }
}
