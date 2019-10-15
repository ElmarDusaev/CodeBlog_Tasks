using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task192
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку:");
                string str = Console.ReadLine();
                Console.WriteLine(new string('♥', 25));
                Console.WriteLine(str.OnlyThird());
                Console.WriteLine(str.Penultimate());
                Console.WriteLine(str.FirstFive());
                Console.WriteLine(str.AllInsteadLastTwo());
                Console.WriteLine(str.AllEven());
                Console.WriteLine(str.AllOdd());
                Console.WriteLine(str.ReverseStr());
                Console.WriteLine(str.ReverseLastThrowOne());
                Console.WriteLine(str.Length);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Read();
        }
    }

    static class StrHelper
    {

        public static char OnlyThird(this string str)
        {
            if (str.Length > 2) return str[2];

            throw new ArgumentException($"Строка {str} имеет меньше 3 символов");
        }

        public static char Penultimate(this string str)
        {
            if (str.Length > 1) return str[str.Length - 2];

            throw new ArgumentException($"Строка {str} имеет меньше 2 символов");
        }

        public static string FirstFive(this string str)
        {
            if (str.Length > 4) return str.Substring(0, 5);

            throw new ArgumentException($"Строка {str} имеет меньше 5 символов");
        }

        public static string AllInsteadLastTwo(this string str)
        {
            if (str.Length > 2) return str.Substring(0, str.Length - 2);

            throw new ArgumentException($"Строка {str} имеет меньше 2 символов");
        }

        public static string AllEven(this string str)
        {
            string tempStr = "";
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 == 0) tempStr += str[i];
                }

                return tempStr;

            }


            throw new ArgumentException($"Строка пуста");

        }

        public static string AllOdd(this string str)
        {
            string tempStr = "";
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (i % 2 != 0) tempStr += str[i];
                }

                return tempStr;

            }


            throw new ArgumentException($"Строка пуста");

        }

        public static string ReverseStr(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return new string(str.Reverse().ToArray());

            }


            throw new ArgumentException($"Строка пуста");

        }


        public static string ReverseLastThrowOne(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                string tempStr = "";

                for (int i = str.Length - 1; i >= 0; i = i - 2)
                {
                    tempStr += str[i];
                }

                return tempStr;


            }


            throw new ArgumentException($"Строка пуста");

        }

    }

}
