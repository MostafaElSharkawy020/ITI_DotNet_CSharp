namespace Lab4
{
    class Company
    {
        public List<Department> Departments { get; }
        public Company()
        {
            Departments = new List<Department>();
        }
        public void Create()
        {
            Console.WriteLine("Creating company:");
            Console.Write("Enter number of departments: ");
            int departmentsNumber = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < departmentsNumber; i++)
            {
                Console.WriteLine($"Creating department {i + 1}:");
                Department department = new Department();
                department.Create();
                Departments.Add(department);
            }
        }
        public void Display()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Company Structure:");
            foreach (var department in Departments)
            {
                Console.WriteLine($"Department: {department.Name}");
                foreach (var employee in department.Employees)
                {
                    Console.WriteLine($"\tEmployee: {employee.Name}");
                    foreach (var course in employee.Courses)
                    {
                        Console.WriteLine($"\t\tCourse: {course.Name}");
                    }
                }
            }
            Console.WriteLine("-------------------------------------------");
        }
    }
}
