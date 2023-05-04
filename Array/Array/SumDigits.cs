using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class SumDigits
    {
        public void Sum()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                num /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
