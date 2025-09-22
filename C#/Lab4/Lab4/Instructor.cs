namespace Lab4
{
    class Instructor : Person
    {
        public int Id { get; set; }
        Course Course { get; set; }
        public Instructor()
        {
            Id = IdGenerator.GenerateId();
            Course = new Course();
        }
        public void Create()
        {
            Console.Write("Enter instructor name: ");
            Name = Console.ReadLine() ?? "";
            Console.Write("Enter instructor age: ");
            Age = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("Enter course details:");
            Course course = new Course();
            course.Create();
            TeachCourse(course);
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Teaching Course: {Course.Name}, Level: {Course.Level}");
        }
        public void TeachCourse(Course course)
        {
            this.Course = course;
        }

        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("I am teaching a Teacher");
        }
    }
}
