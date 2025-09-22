namespace Lab1
{
    class Subject
    {
        public int code { get; set; }
        public string name { get; set; }
    }
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }
    }
    internal class Program
    {
        public static void Task1()
        {
            List<int> numbers = new List<int> { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            var query1 = numbers.Distinct().Order();
            foreach (var number in query1)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-----");

            var query2 = query1.Select(n => $"( Number = {n}, Multiply = {n * n} )");
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");
        }
        public static void Task2MethodExpression()
        {
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var query1 = names.Where(name => name.Length == 3);
            foreach (var name in query1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----");

            var query2 = names
                .Where(name => name.ToLower().Contains('a'))
                .OrderBy(name => name.Length);
            foreach (var name in query2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----");

            var query3 = names.Take(2);
            foreach (var name in query3)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----");
        }
        public static void Task2QueryExpression()
        {
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var query1 = from name in names
                         where name.Length == 3
                         select name;
            foreach (var name in query1)
                {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----");

            var query2 = from name in names
                         where name.ToLower().Contains('a')
                         orderby name.Length
                         select name;
            foreach (var name in query2)
                {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----");

            var query3 = (from name in names
                          select name).Take(2);
            foreach (var name in query3)
                {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----");
        }
        public static void Task3()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject { code = 22, name = "EF" },
                        new Subject { code = 33, name = "UML" }
                    }
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject { code = 22, name = "EF" },
                        new Subject { code = 34, name = "XML" },
                        new Subject { code = 25, name = "JS" }
                    }
                },
                new Student
                {
                    Id = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    Subjects = new Subject[]
                    {
                        new Subject { code = 22, name = "EF" },
                        new Subject { code = 25, name = "JS" }
                    }
                },
                new Student
                {
                    Id = 1,
                    FirstName = "Ali",
                    LastName = "Ali",
                    Subjects = new Subject[]
                    {
                        new Subject { code = 33, name = "UML" },
                    }
                }
            };

            var query1 = students
                .Select(s => $"( FullName = {s.FirstName} {s.LastName}, NoOfSubjects = {s.Subjects.Length})");
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");

            var query2 = students
                .OrderByDescending(s => s.FirstName)
                .ThenBy(s => s.LastName)
                .Select(s => $"{s.FirstName} {s.LastName}");
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");

            var query3 = students
                .SelectMany(s => s.Subjects,
                (student, subject) => $"( StudentName = {student.FirstName} {student.LastName}," +
                $" SubjectName = {subject.name} )");
            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----");

            var bonusQuery = students
                .GroupBy(s => s.FirstName + " " + s.LastName);
            foreach (var group in bonusQuery)
            {
                Console.WriteLine(group.Key);
                foreach (var subject in group)
                {
                    foreach (var sub in subject.Subjects)
                    {
                        Console.WriteLine($"   {sub.name}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Task1();
            Task2MethodExpression();
            Task3();
        }
    }
}
