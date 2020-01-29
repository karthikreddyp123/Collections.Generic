using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class SortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sortedList = new SortedList<string, string>();
            sortedList.Add("Test1", "Test@123");
            sortedList.Add("Admin", "Admin@123");
            sortedList.Add("Temp", "Temp@123");
            sortedList.Add("Demo", "Demo@123");
            sortedList.Add("Test2", "Test2@123");
            sortedList.Remove("Admin");
            if (sortedList.ContainsKey("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                sortedList.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }

            // Get a collection of the keys.
            ICollection<string> key = sortedList.Keys;
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sortedList[k]);
            }
            Console.ReadKey();
        }
    }
}
