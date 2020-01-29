using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class ListDemo
    {
        static void Main(string[] args)
        {
			IList<int> intList1 = new List<int>();
			intList1.Add(10);
			intList1.Add(20);
			intList1.Add(30);
			intList1.Add(40);

			List<int> intList2 = new List<int>();

			intList2.AddRange(intList1);


			Console.WriteLine(intList2.Count);
			Console.WriteLine("Printing Eleemnts:");
			intList2.ForEach(el => Console.WriteLine(el));
			intList2.Insert(1, 11);
			intList2.Remove(10); // removes the 10 from a list

			intList2.RemoveAt(2); //removes the 3rd element (index starts from 0)
			Console.WriteLine("Printing Eleemnts:");
			foreach (var el in intList2)
				Console.WriteLine(el);
			Console.ReadLine();
		}

    }
}
