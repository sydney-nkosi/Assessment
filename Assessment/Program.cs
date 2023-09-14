namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Palindrome palindrome = new Palindrome();
                palindrome.IsPalindrome();

                PascalTriangle pascalTriangle = new PascalTriangle();
                pascalTriangle.DrawPascalTraingle();
            }
        }
    }
}