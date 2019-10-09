using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task180
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Максимальное число:");
            var res = maxValue(a, b);
            Console.WriteLine(res);
            Console.ReadKey();

        }

        public static int maxValue(int a, int b)
        {
            return (a + b + Math.Abs(a - b)) / 2;
        }
    }
}
