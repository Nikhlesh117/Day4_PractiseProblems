using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Array_List
    {
        public void List()
        {
            
            ArrayList arrayList = new ArrayList();

            // Add items to the ArrayList
            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Orange");

            // Read items from the ArrayList
            Console.WriteLine("Items in the ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Update an item in the ArrayList
            arrayList[1] = "Grapes";
            Console.WriteLine("\nAfter updating an item in the ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Remove an item from the ArrayList
            arrayList.Remove("Apple");
            Console.WriteLine("\nAfter removing an item from the ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Insert an item at a specific index in the ArrayList
            arrayList.Insert(1, "Pineapple");
            Console.WriteLine("\nAfter inserting an item in the ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // Clear all items from the ArrayList
            arrayList.Clear();
            Console.WriteLine("\nAfter clearing all items from the ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


        }

    }
}
