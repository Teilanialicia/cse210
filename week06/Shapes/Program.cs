namespace week06
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = [];
            
            Circle circle = new Circle(3.3, "green");
            Rectangle rectangle = new Rectangle(2.1, 4.4, "blue");
            Square square = new Square(8.8, "purple");

            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(square);

            foreach(Shape shape in shapes)
            {
                Console.WriteLine(shape.GetArea());
                Console.WriteLine(shape.GetColor());
            }
        }
    }
}