using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Collections
    {
        public Collections()
        {
            List<int> numbers = new List<int>() {1, 2, 3 };

            Console.WriteLine("Element at index 0: " + numbers[0]);
            
            numbers[1] = 4;
            Console.WriteLine("Modified element at index 1: " + numbers[1]);

            Console.WriteLine("NUmber of items: " + numbers.Count);
            numbers.RemoveAt(0);
            Console.WriteLine("NUmber of items: " + numbers.Count);
        }
    }
}
