namespace Lab4
{
    class Rectangle : Shape,IDrawable
    {
        public double width { get; set; }
        public double height { get; set; }
        public override double Area()
        {
            return width * height;
        }
        public void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public override void Create()
        {
            Console.Write("Enter width: ");
            width = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine() ?? "0");
        }
    }
}
