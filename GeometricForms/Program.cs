namespace GeometricForms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            //create forms
            Circle circle = new Circle(200, 200, 50);
            Rectangle rectangle = new Rectangle(300, 300, 80, 40);  
            Square square = new Square(150, 150, 60);

            //add forms to list
            shapes.Add(circle);
            shapes.Add(rectangle);
            shapes.Add(square);

            foreach (Shape shape in shapes)
            {
                Shape.PrintPosition(shape); //object 'shape' gets passed
                shape.PrintArea();

                if (shape is IRotatable)
                {
                    ((IRotatable)shape).RotateClockwise90Degrees();
                    Console.WriteLine("Figur wurde um 90 Grad gedreht.");
                }
                else
                {
                    Console.WriteLine("Figur kann nicht gedreht werden.");
                }
            }

        }
    }
}