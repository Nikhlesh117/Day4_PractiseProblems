using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class UniqueElements
    {
        public void Unique()
        {
            int[] arr = { 1, 2, 3, 2, 4, 5, 4, 6, 7, 6, 8, 9, 9 };
            Console.Write("Unique elements in the array: ");

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }
                if (count == 1)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
