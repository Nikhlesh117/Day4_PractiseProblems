using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FrequencyElement
    {
        public void Frequency_Element()
        {

            Console.Write("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            // Input array elements from user
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == -1)
                {
                    continue;
                }
                int count = 1; 
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = -1; 
                    }
                }
                Console.WriteLine("The frequency of " + arr[i] + " is " + count);
            }

        }
    }
}
