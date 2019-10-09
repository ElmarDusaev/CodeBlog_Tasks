using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task179
{
    class Program
    {
        static int count = 0;
        static int sum = 0;
        static StringBuilder simpleStrNumbers = new StringBuilder();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var simpleNumber = int.Parse(Console.ReadLine());


            for (int i = 2; i <= simpleNumber; i++)
            {
                if (i.isSimpleNumber()) AddSimpleNumber(i);
            }

            Console.WriteLine("Простые числа: " + simpleStrNumbers.ToString());
            Console.WriteLine("Количество простых чисел: " + count);
            Console.WriteLine("Сумма простых чисел: " + sum);
            Console.Read();
        }

        public static void AddSimpleNumber(int number)
        {
            simpleStrNumbers.Append($"{number} ");
            count++;
            sum += number;
        }

    }

    static class NumberHelper
    {
        public static bool isSimpleNumber(this int number)
        {
            for (int i = 2; i <= number/2; i++)
            {
                if (number % i == 0) return false;

            }
            return true;
        }
    }
}
