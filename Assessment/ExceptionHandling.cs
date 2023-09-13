using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class ExceptionHandling
    {
        public ExceptionHandling()
        {
            int numerator = 10;
            int denominator = 0;
            int result = 0;

            try
            {
                result = numerator / denominator;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
