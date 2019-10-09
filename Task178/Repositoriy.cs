using System;
using System.Collections.Generic;

namespace Task178
{
    public static class Repository
    {
        public static List<Student> getData()
        {
            List<Student> students = new List<Student>();
            var random = new Random();

            for (int i = 1; i <= 30; i++)
            {
                students.Add(new Student()
                {
                    ID = i,
                    Name = "Студент " + i,
                    Mark = random.Next(0, 40)
                });
            }
            return students;
        }
    }


}
