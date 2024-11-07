namespace Polymorphism
{

    //Sub-klass som ärver från Geometry
    public class Rectangle : Geometry
    {

        //Egenskaper för rektangelns bredd och höjd
        public double Width { get; set; }
        public double Height { get; set; }

        //Fasta värden på egenskaperna
        public Rectangle() 
        { 
            Width = 5;
            Height = 10;
        }


        //Override Area-metod som beräknar rektangelns area
        public override double Area()
        {
            return Width * Height;
        }
    }
}
