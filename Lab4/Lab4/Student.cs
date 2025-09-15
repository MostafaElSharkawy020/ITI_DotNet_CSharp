namespace Lab4
{
    class Student : Person
    {
        public int Id { get; set; }
        public List<Grade> Grades { get; }
        public List<Course> Courses { get; } = new List<Course>();
        public Student()
        {
            Id = IdGenerator.GenerateId();
            Grades = new List<Grade>();
        }
        public void Create()
        {
            Console.Write("Enter student name: ");
            Name = Console.ReadLine() ?? "";
            Console.Write("Enter student age: ");
            Age = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Enter number of courses to register: ");
            int coursesNumber = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < coursesNumber; i++)
            {
                Console.WriteLine($"Registering course {i + 1}:");
                RegisterCourse();
            }
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine("Courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine($"\tCourse Name: {course.Name}, Level: {course.Level}");
            }
            Console.WriteLine($"Total Grade: {GetTotalGrade().Value}");
        }
        public void RegisterCourse()
        {
            Course course = new Course();
            course.Create();
            Courses.Add(course);
            switch(course.Level)
            {
                case CourseLevel.Beginner:
                    Console.WriteLine("Good Luck starting out!");
                    break;
                case CourseLevel.Advanced:
                    Console.WriteLine("This will be challenging!");
                    break;
            }
            Console.Write("Enter grade for this course: ");
            int gradeValue = int.Parse(Console.ReadLine() ?? "0");
            Grades.Add(new Grade(gradeValue));
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("I am a Learner");
        }
        public Grade GetTotalGrade()
        {
            Grade total = new Grade();
            foreach (var grade in Grades)
            {
                total = total + grade;
            }
            return total;
        }
        public bool IsFirstGradeEqualsLastGrade()
        {
            if (Grades.Count == 0) return false;
            return Grades[0] == Grades[^1];
        }
    }
}
