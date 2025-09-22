namespace Lab4
{
    internal class Program
    {
        public static void CompanyDemo()
        {
            Console.WriteLine("Company Demo:\n");
            Company company = new Company();
            company.Create();
            Console.WriteLine();
            company.Display();
        }
        public static void ShapeDemo()
        {
            Console.WriteLine("\nShape Demo:\n");
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter number of shapes: ");
            int shapesNumber = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < shapesNumber; i++)
            {
                Console.WriteLine($"Creating shape {i + 1}:");
                Console.Write("Enter shape type (circle/rectangle): ");
                string shapeType = Console.ReadLine() ?? "";
                Shape shape;
                if (shapeType.ToLower() == "circle")
                {
                    shape = new Circle();
                }
                else
                {
                    shape = new Rectangle();
                }
                shape.Create();
                shapes.Add(shape);
            }

            Console.WriteLine("\nDisplaying Shapes:");
            for(int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"Shape {i + 1}:");
                Console.WriteLine($"Area: {shapes[i].Area()}");
                if(shapes[i] is Circle circle)
                {
                    circle.Draw();
                }
                else if(shapes[i] is Rectangle rectangle)
                {
                    rectangle.Draw();
                }
                Console.WriteLine();
            }
        }
        public static void StudentDemo()
        {
            Console.WriteLine("\nStudent Demo:\n");
            Console.Write("Enter number of students: ");
            int studentsNumber = int.Parse(Console.ReadLine() ?? "0");
            List<Student> students = new List<Student>();
            for (int i = 0; i < studentsNumber; i++)
            {
                Console.WriteLine($"Creating student {i + 1}:");
                Student student = new Student();
                student.Create();
                students.Add(student);
            }
            Console.WriteLine("\nDisplaying Students:");
            foreach (var student in students)
            {
                student.Print();
                Console.WriteLine();
            }
        }

        public static void InstructorDemo()
        {
            Console.WriteLine("\nInstructor Demo:\n");
            Console.Write("Enter number of instructors: ");
            int instructorsNumber = int.Parse(Console.ReadLine() ?? "0");
            List<Instructor> instructors = new List<Instructor>();
            for (int i = 0; i < instructorsNumber; i++)
            {
                Console.WriteLine($"Creating instructor {i + 1}:");
                Instructor instructor = new Instructor();
                instructor.Create();
                instructors.Add(instructor);
            }
            Console.WriteLine("\nDisplaying Instructors:");
            foreach (var instructor in instructors)
            {
                instructor.Print();
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ShapeDemo();
            CompanyDemo();
            StudentDemo();
            InstructorDemo();
        }
    }
}
