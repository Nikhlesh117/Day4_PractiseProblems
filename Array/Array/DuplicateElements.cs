using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class DuplicateElements
    {
        public void NoOfDuplicateElements() 
        {
            int[] arr = { 1, 2, 3, 2, 3, 4, 5, 4, 6, 7, 8, 9, 9, 10 };
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("Total number of duplicate elements in the array: " + count);
        }
    }
}
