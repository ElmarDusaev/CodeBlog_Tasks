using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task183
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            Console.WriteLine("Введите сторону А");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону Б");
            int sideB = int.Parse(Console.ReadLine());

            while (sideA != 0 && sideB != 0)
            {
                if (sideA > sideB) sideA -= sideB;
                else sideB -= sideA;
                counter++;
            }
            Console.WriteLine(new string('*',25));
            Console.WriteLine($"Количество квадратов: {counter}");
            Console.Read();
        }
    }
}
