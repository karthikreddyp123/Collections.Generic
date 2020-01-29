using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Generic
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary =new Dictionary<string, string>();
            dictionary.Add("Test1", "Test@123");
            dictionary.Add("Admin", "Admin@123");
            dictionary.Add("Temp", "Temp@123");
            dictionary.Add("Demo", "Demo@123");
            dictionary.Add("Test2", "Test2@123");
            dictionary.Remove("Admin");
            if (dictionary.ContainsKey("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                dictionary.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }

            // Get a collection of the keys.
            ICollection<string> key = dictionary.Keys;
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + dictionary[k]);
            }
            Console.ReadKey();
        }
    }
}
