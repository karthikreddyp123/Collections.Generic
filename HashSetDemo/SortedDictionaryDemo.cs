using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedDictionaryDemo
{
    class SortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();
            sortedDictionary.Add("Test1", "Test@123");
            sortedDictionary.Add("Admin", "Admin@123");
            sortedDictionary.Add("Temp", "Temp@123");
            sortedDictionary.Add("Demo", "Demo@123");
            sortedDictionary.Add("Test2", "Test2@123");
            sortedDictionary.Remove("Admin");
            if (sortedDictionary.ContainsKey("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                sortedDictionary.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }

            // Get a collection of the keys.
            ICollection<string> key = sortedDictionary.Keys;
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sortedDictionary[k]);
            }
            Console.ReadKey();
        }
    }
}
