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
            Console.WriteLine("Enter any word or number then press enter");
            var input = Console.ReadLine();

            if(int.TryParse(input, out int number) )
            {
                IsPalindromeNumber(number);
            }
            else if(ContainsLetters(input))
            {
                IsPalindromeString(input);
            }
            else
                Console.WriteLine("You did not do as told. Please try again.");

        }

        private void IsPalindromeNumber(int number)
        {
            int reversed = int.Parse(ReverseString(number.ToString()));

            if (number == reversed)
                Console.WriteLine($"Number {number} is palindrome.\n");
            else
                Console.WriteLine($"Number {number} is not palindrome.\n");
        }

        private bool ContainsLetters(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        private void IsPalindromeString(string word)
        {
            if (string.Equals(word, ReverseString(word), StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Word {word} is palindrome.\n");
            else
                Console.WriteLine($"Word {word} is not palindrome.\n");
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
