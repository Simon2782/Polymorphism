namespace Polymorphism
{

    //Samma här som hos rektangeln fast med en kvadrats egenskaper
    public class Square : Geometry
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 4;
        }

        public override double Area()
        {
            return Side * Side;
        } 
    }
}
