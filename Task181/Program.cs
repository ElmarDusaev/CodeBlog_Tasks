using System;
using System.Linq;

namespace Task181
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Repository.getHackedUsers();
            var result = from i in data group i by i.Value into r select new { pass = r.Key, count = r.Count()};
            var top10 = result.OrderByDescending(a => a.count).Take(10);
            Console.WriteLine("****************** THE 10 MOST POPULAR PASSWORDS ******************");
            foreach (var item in top10)
            {
                Console.WriteLine("Password: \""+item.pass + "\" \t Count: " + item.count);
            }
            Console.ReadKey();

        }
    }
}
