using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Palindrome
    {
        public void IsPalindrome()
        {
            Console.WriteLine("Enter any word then press enter");
            var word = Console.ReadLine().ToLower();

            if(!string.IsNullOrEmpty(word))
            {
                if (string.Equals(word, ReverseString(word), StringComparison.OrdinalIgnoreCase))
                    Console.WriteLine($"{word} is palindrome");
                else
                    Console.WriteLine($"{word} is palindrome");
            }
            else
            {
                Console.WriteLine("You did not do as told. Please restart the app.");
            }
        }

        private string ReverseString(string word)
        {
            if(word.Length == 0 )
                return string.Empty;
            string results = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                results += word[i];
            }
            return results;
        }
    }
}
