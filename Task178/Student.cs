using System;

namespace Task178
{
    public class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Mark { get; set; }
        public int Position { get; set; }

        public int CompareTo(Student other)
        {
            return ID - other.ID;
        }

    }

}
