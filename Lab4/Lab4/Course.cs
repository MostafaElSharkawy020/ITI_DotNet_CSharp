namespace Lab4
{
    enum CourseLevel
    {
        Beginner,
        Intermediate,
        Advanced
    }
    class Course
    {
        public string Name { get; set; } 
        public CourseLevel Level { get; set; }
        public Course()
        {
            Name = "";
        }
        public void Create()
        {
            Console.Write("Enter course name: ");
            Name = Console.ReadLine() ?? "";
            Console.Write("Enter course level (0-Beginner, 1-Intermediate, 2-Advanced): ");
            int level = int.Parse(Console.ReadLine() ?? "0");
            Level = (CourseLevel)level;
        }
    }
}
