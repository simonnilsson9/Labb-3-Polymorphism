namespace Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry Circle = new Circle();
            Geometry Square = new Square();
            Geometry Rectangle = new Rectangle();

            Geometry[] geo = {Circle, Square, Rectangle}; 
            foreach (Geometry item in geo)
            {
                Console.WriteLine($"Area {item}: {item.Area()}");
            }

           
        }
    }
}