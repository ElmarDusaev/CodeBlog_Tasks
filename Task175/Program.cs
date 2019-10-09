using System;
using Task175.Repository;

namespace Task175
{
    class Program
    {
        static void Main(string[] args)
        {

            Data.CreateStatisticFile(@"Repositoriy\Data.txt");

            Console.WriteLine("OK");
            Console.Read();
        }
    }
}
