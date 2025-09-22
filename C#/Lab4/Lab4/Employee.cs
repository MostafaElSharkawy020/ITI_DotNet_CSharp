namespace Lab4
{
    class Employee
    {
        public string Name { get; set; }
        public List<Course> Courses { get; }
        public Employee()
        {
            Name = "";
            Courses = new List<Course>();
        }
        public void Create()
        {
            Console.Write("Enter employee name: ");
            Name = Console.ReadLine() ?? "";

            Console.Write("Enter number of courses: ");
            int coursesNumber = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i < coursesNumber; i++)
            {
                Console.WriteLine($"Creating course {i + 1}:");
                Course course = new Course();
                course.Create();
                Courses.Add(course);
            }
        }
    }
}
