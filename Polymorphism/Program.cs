namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Lista för alla objekten i Gemoetrys sub-klasser
            List<Geometry> shapes = new List<Geometry>
            {
                new Rectangle(),
                new Square(),
                new Circle(),
            };

            //Loopar igenom varje objekt och anropar Area-metoden för varje sub-klass för att visa polymorfism.
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Area of {shape.GetType().Name} {shape.Area():F2}");
            }
        }
    }
}
