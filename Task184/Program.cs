using System;
using System.Collections.Generic;
using System.Linq;

namespace Task184
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime d1 = new DateTime(2019, 10, 09);
            DateTime d2 = new DateTime(2000, 10, 09);
            DateTime d3 = new DateTime(1980, 10, 09);

            List<DateTime> listOfDate = new List<DateTime>();
            listOfDate.Add(d1);
            listOfDate.Add(d2);
            listOfDate.Add(d3);

            listOfDate.Sort();

            var maxDate = listOfDate.Max();

            TimeSpan sumOfDays = new TimeSpan();

            foreach (var item in listOfDate)
            {
                sumOfDays += maxDate.Subtract(item);
            }

            var addCentery = maxDate.AddYears(100).Subtract(sumOfDays);
            var countToDate = (addCentery - maxDate).Days / listOfDate.Count;
            var Result = maxDate.Add(TimeSpan.FromDays(countToDate));
            Console.WriteLine(Result.ToShortDateString());

            Console.Read();


        }
    }
}
