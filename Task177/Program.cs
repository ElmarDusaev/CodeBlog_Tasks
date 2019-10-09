using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task177
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,5,5 };
            //V1
            var result = array.Distinct().Count();
            Console.WriteLine(result);

            //V2
            HashSet<int> uniqArr = new HashSet<int>();
            foreach (var item in array)
            {
                uniqArr.Add(item);
            }
            Console.WriteLine(uniqArr.Count);

            //V3
            Array.Sort(array);
            int counter = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != array[i + 1]) counter++;
            }
            Console.WriteLine(counter);
            
            Console.ReadKey();
        }
    }
}
