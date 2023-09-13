using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Overloading
    {
        public Overloading()
        {
            Calculator calc = new Calculator();
            int result1 = calc.Add(2, 3);       
            int result2 = calc.Add(2, 3, 4);
        }
    }
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
