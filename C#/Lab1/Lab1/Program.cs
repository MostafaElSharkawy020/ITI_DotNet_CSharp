using System.Runtime.InteropServices;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.WriteLine("Task 1");
            Console.Write("Enter a character: ");
            string inputChar = Console.ReadLine();
            int asciiCode = (int)inputChar[0];
            Console.WriteLine($"The ASCII Code of {inputChar} is {asciiCode}");
            #endregion

            #region Task2
            Console.WriteLine("\nTask 2");
            Console.Write("Enter an ASCII Code: ");
            int asciiCode2 = Convert.ToInt32(Console.ReadLine());
            char outputChar2 = (char)asciiCode2;
            Console.WriteLine($"The Char of {asciiCode2} is {outputChar2}");
            #endregion

            #region Task3
            Console.WriteLine("\nTask 3");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
            #endregion

            #region Task4
            Console.WriteLine("\nTask 4");
            Console.Write("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum = {number1 + number2}");
            Console.WriteLine($"Subraction = {number1 - number2}");
            Console.WriteLine($"Multiplication = {number1 * number2}");
            #endregion

            #region Task5
            Console.WriteLine("\nTask 5");
            Console.Write("Enter a number: ");
            int degree = Convert.ToInt32(Console.ReadLine());
            if(degree >= 90)
                Console.WriteLine("A");
            else if(degree >= 80)
                Console.WriteLine("B");
            else if(degree >= 70)
                Console.WriteLine("C");
            else if(degree >= 60)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
            #endregion

            #region Task6
            Console.WriteLine("\nTask 6");
            Console.Write("Enter a number: ");
            int multiplicationTableNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication Table of {multiplicationTableNumber}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{multiplicationTableNumber} x {i} = {multiplicationTableNumber * i}");
            }
            #endregion
        }
    }
}
