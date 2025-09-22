namespace Lab4
{
    class Department
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; }
        public Department()
        {
            Name = "";
            Employees = new List<Employee>();
        }
        public void Create()
        {
            Console.Write("Enter department name: ");
            Name = Console.ReadLine() ?? "";
            Console.Write("Enter number of employees: ");
            int employeesNumber = int.Parse(Console.ReadLine() ?? "0");
            for (int i = 0; i < employeesNumber; i++)
            {
                Console.WriteLine($"Creating employee {i + 1}:");
                Employee employee = new Employee();
                employee.Create();
                Employees.Add(employee);
            }
        }
    }
}
