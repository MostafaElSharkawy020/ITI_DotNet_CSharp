namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calculator Class Demo

            int int1 = 10, int2 = 5;
            double double1 = 10.5, double2 = 5.5;
            Calculator calculator = new Calculator();

            Console.WriteLine("Calculator Class Demo");

            Console.WriteLine("Integer Operations:");
            Console.WriteLine($"{int1} + {int2} = {calculator.Add(int1, int2)}");
            Console.WriteLine($"{int1} - {int2} = {calculator.Subtract(int1, int2)}");
            Console.WriteLine($"{int1} * {int2} = {calculator.Multiply(int1, int2)}");
            Console.WriteLine($"{int1} / {int2} = {calculator.Divide(int1, int2)}");
            Console.WriteLine();

            Console.WriteLine("Double Operations:");
            Console.WriteLine($"{double1} + {double2} = {calculator.Add(double1, double2)}");
            Console.WriteLine($"{double1} - {double2} = {calculator.Subtract(double1, double2)}");
            Console.WriteLine($"{double1} * {double2} = {calculator.Multiply(double1, double2)}");
            Console.WriteLine($"{double1} / {double2} = {calculator.Divide(double1, double2)}");
            Console.WriteLine();

            #endregion

            #region McqQuestion Class Demo

            Console.WriteLine("MCQ Class Demo");
            Question mcq = new McqQuestion("Sample Question", "What is the capital of France?", 4);
            Console.WriteLine();
            mcq.Show();
            Console.WriteLine();

            #endregion

            #region MCQ Array Demo

            
            Console.WriteLine("MCQ Array Demo");
            Console.Write("Enter the number of questions: ");

            int numQuestions = Convert.ToInt32(Console.ReadLine());
            int totalMark = 0;
            McqQuestion[] questions = new McqQuestion[numQuestions];
            string header;
            string body;

            for (int i=0;i<numQuestions; i++)
            {
                Console.WriteLine($"\nEntering details for question {i + 1}:");
                Console.Write("Enter question header: ");
                header = Console.ReadLine();
                Console.Write("Enter question body: ");
                body = Console.ReadLine();
                questions[i] = new McqQuestion(header,body,4);
            }

            Console.WriteLine("\n--- Quiz Start ---\n");
            for(int i=0;i<numQuestions;i++)
            {
                Console.WriteLine($"Question {i + 1}:");
                questions[i].Show();
                Console.Write("Enter your choice (number): ");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                totalMark += questions[i].GetMark(userChoice);
                Console.WriteLine();
            }

            Console.WriteLine($"Your total mark is: {totalMark} out of {numQuestions}");

            #endregion
        }
    }
}
