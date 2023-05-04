using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ReverseString
    {
        public void StringRev() 
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            string reversedString = "";

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string reversedWord = "";

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedWord += word[j];
                }

                reversedString += reversedWord + " ";
            }

            Console.WriteLine("Reversed string: " + reversedString);
        }

    }
    
}
