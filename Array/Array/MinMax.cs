using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class MinMax
    {
        public void Min_Max() 
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine("Maximum element in the array: " + max);
            Console.WriteLine("Minimum element in the array: " + min);
        }
    }
}
