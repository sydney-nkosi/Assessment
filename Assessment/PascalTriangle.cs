using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class PascalTriangle
    {
        public void DrawPascalTraingle()
        {
            int rows;
            do
            {
                Console.WriteLine("Enter the number of rows of the Pascal triangle: ");
                rows = int.Parse(Console.ReadLine());
            } while (rows < 1);

            int[] pascalTriangle = new int[rows];
            pascalTriangle[0] = 1;
            for (int i = 1; i < rows; i++)
            {
                pascalTriangle[i] = 1;
                for (int j = i - 1; j > 0; j--)
                {
                    pascalTriangle[j] += pascalTriangle[j - 1];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0} ", pascalTriangle[j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
