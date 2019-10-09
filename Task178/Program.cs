using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task178
{
    class Program
    {

        static void Main(string[] args)
        {


            var students = Repository.getData();
            var tempStudentsPosition = students.
                                        OrderByDescending(a => a.Mark).
                                        GroupBy(a => a.Mark).
                                        Select((a, i) => new { Mark = a.Key, Position = ++i });

            var studentsWithPosition = from i in students
                                       from j in tempStudentsPosition
                                       where i.Mark == j.Mark
                                       select new Student
                                       {
                                           ID = i.ID,
                                           Name = i.Name,
                                           Mark = i.Mark,
                                           Position = j.Position
                                       };

            var uniqPosition = studentsWithPosition.Select(a => a.Position).Distinct();

            foreach (var item in uniqPosition)
            {
                var it = from i in studentsWithPosition where i.Position == item select i;
                Console.WriteLine($"Место: {item}");
                Console.WriteLine($"Всего заняло: { it.Count()} чел.");
                if (it.Count() > 1)
                    Console.WriteLine(it.Min().Name + " " + it.Max().Name);
                else Console.WriteLine(it.FirstOrDefault().Name);
                Console.WriteLine();
            }

            Console.Read();

        }

    }

}
