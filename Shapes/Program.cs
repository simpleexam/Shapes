
namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle(10),
                new Rectangle(5,10),
                new Rectangle(6,7),
                new Circle(2)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(
                    shape.GetPerimetr()+"\n"+
                    shape.GetArea() +"\n\n");  
            }
        }
    }
}