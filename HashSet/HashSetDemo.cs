using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            string[] arr1 = 
                {
                    "bus",
                    "truck",
                    "bus",
                    "car",
                    "truck",
                    "apple"
                };

            Console.WriteLine(string.Join(",", arr1));

            // HashSet
            var h = new HashSet<string>(arr1);

            // eliminates duplicate words
            string[] arr2 = h.ToArray();

            Console.WriteLine(string.Join(",", arr2));
            Console.ReadLine();
        }
    }
}
