
namespace Assessment.Inheritance
{
    class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Shape is being drawn.");
        }
    }

    class Circle : Shape
    {
        int GetRadius() { return 0; }
    }

    class Square : Shape
    {
        int GetNumberOfSides() {  return 0; }
    }

}
