using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Dictionarys
    {
        public void Dict()
        {
            // Create a new dictionary
            Dictionary<string, int> dict = new Dictionary<string, int>();

            // Add data to the dictionary
            dict.Add("apple", 25);
            dict.Add("banana", 10);
            dict.Add("mango", 50);
            dict.Add("orange", 15);


            // Read data from the dictionary
            Console.WriteLine("Reading data from dictionary:");
            foreach (KeyValuePair<string, int> fruit in dict)
            {
                Console.WriteLine("Fruit: " + fruit.Key + ", Price: " + fruit.Value);
            }


            // Update data in the dictionary
            Console.WriteLine("\nUpdating data in dictionary:");
            dict["banana"] = 12;
            Console.WriteLine("Price of banana: " + dict["banana"]); 

            // Delete data from the dictionary
            Console.WriteLine("\nDeleting data from dictionary:");
            dict.Remove("mango");
            Console.WriteLine(dict.ContainsKey("mango")); 

            //Clear all items from the dictionary
            dict.Clear();
            Console.WriteLine("\nDeleting data from dictionary:");  
            Console.WriteLine(dict.Count);
        }
    }
}
