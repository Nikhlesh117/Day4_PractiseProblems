using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int a = 10;
            int b = 5;

            Console.WriteLine(calculator.Add(a, b));
            Console.WriteLine(calculator.Subtract(a, b));
            Console.WriteLine(calculator.Multiply(a, b));
            Console.WriteLine(calculator.Divide(a, b));

            Console.ReadKey();
        }
    }
}
