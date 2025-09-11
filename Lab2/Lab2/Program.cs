using System.Runtime.InteropServices;

namespace Lab2
{
    internal class Program
    {
        struct Time
        {
            public int hours;
            public int minutes;
            public int seconds;

            public void print()
            {
                Console.WriteLine($"{hours}H:{minutes}M:{seconds}S");
            }

        }
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("Task 1:");
            Console.Write("Enter the number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            string[] studentsNames = new string[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                studentsNames[i] = Console.ReadLine();
            }
            foreach (string name in studentsNames)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region Task2
            Console.WriteLine("\nTask 2:");
            Console.Write("Enter the number of Tracks: ");
            int numberOfTracks = int.Parse(Console.ReadLine());
            int[][] trackStudentsAges = new int[numberOfTracks][];
            for (int i = 0; i < numberOfTracks; i++)
            {
                Console.Write($"Enter the number of students in Track {i + 1}: ");
                int numberOfStudentsInTrack = int.Parse(Console.ReadLine());
                trackStudentsAges[i] = new int[numberOfStudentsInTrack];
                for (int j = 0; j < numberOfStudentsInTrack; j++)
                {
                    Console.Write($"Enter the age of student {j + 1} in Track {i + 1}: ");
                    trackStudentsAges[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < numberOfTracks; i++)
            {
                Console.WriteLine($"Ages of students in Track {i + 1}:");
                foreach (int age in trackStudentsAges[i])
                {
                    Console.WriteLine(age);
                }
                Console.WriteLine($"Avg Age = {trackStudentsAges[i].Average()}");
            }

            #endregion
            #region Task3
            Console.WriteLine("\nTask 3:");
            Time time;
            time.hours = 1;
            time.minutes = 30;
            time.seconds = 45;
            time.print();
            #endregion
        }
    }
}
