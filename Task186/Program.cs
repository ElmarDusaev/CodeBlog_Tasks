using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task186
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введите число X:");
                int X = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число Y:");
                int Y = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число Z:");
                int Z = int.Parse(Console.ReadLine());

                var res = isRelativePrime(X, Y, Z);

                if (res.status) Console.WriteLine($"Числа X = {X}, Y = {Y}, Z = {Z} взаимно простые");
                else Console.WriteLine($"Для чисел X = {X}, Y = {Y}, Z = {Z} общие делители - {res.array.ArrayToString()}");

                Console.WriteLine(new string('*', 50));

            }
        }

        public static (bool status, HashSet<int> array) isRelativePrime(int X, int Y, int Z)
        {
            var NodX = FindNod(X);
            var NodY = FindNod(Y);
            var NodZ = FindNod(Z);

            NodX.IntersectWith(NodY);
            NodX.IntersectWith(NodZ);

            if (NodX.Count > 0) return (false, NodX);

            return (true, NodX);
        }

        private static HashSet<int> FindNod(int number)
        {
            HashSet<int> nod = new HashSet<int>();

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0) nod.Add(i);
            }
            return nod;
        }
    }

    static class ExtClass
    {
        public static string ArrayToString(this HashSet<int> val)
        {

            string str = "";

            foreach (var item in val)
            {
                str += item + "; ";
            }

            return str;
        }
    }
}
