
namespace Assessment.Inheritance
{
    interface IWalkable
    {
        void Walk();
    }
    interface IFlyable
    {
        void Fly();
    }

    class Bird : IWalkable, IFlyable
    {
        public void Walk()
        {
            Console.WriteLine("Bird is walking.");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }

}
