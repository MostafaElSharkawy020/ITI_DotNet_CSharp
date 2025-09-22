namespace Lab4
{
    class Circle : Shape, IDrawable
    {
        public double radius { get; set; }
        public override double Area()
        {
            return System.Math.PI * radius * radius;
        }
        public void Draw()
        {
            int r = (int)radius;
            for (int i = -r; i <= r; i++)
            {
                for (int j = -r; j <= r; j++)
                {
                    if (i * i + j * j <= r * r)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public override void Create()
        {
            Console.Write("Enter radius: ");
            radius = double.Parse(Console.ReadLine() ?? "0");
        }
    }
}
