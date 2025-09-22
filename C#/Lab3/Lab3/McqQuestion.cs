namespace Lab3
{
    internal class McqQuestion : Question
    {
        public string[] choices { get; set; }
        public int correctChoice { get; set; }

        public McqQuestion() : base()
        {
            this.choices = new string[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter choice {i + 1}: ");
                choices[i] = Console.ReadLine();
            }
            Console.Write("Enter the number of the correct choice: ");
            correctChoice = Convert.ToInt32(Console.ReadLine());
        }

        public McqQuestion(string header, string body, int choicesNumber) : base(header, body)
        {
            this.choices = new string[choicesNumber];
            for (int i = 0; i < choicesNumber; i++)
            {
                Console.Write($"Enter choice {i + 1}: ");
                choices[i] = Console.ReadLine();
            }
            Console.Write("Enter the number of the correct choice: ");
            correctChoice = Convert.ToInt32(Console.ReadLine());
        }

        public override void Show()
        {
            base.Show();
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine($"({i + 1}): {choices[i]}");
            }
        }
        public int GetMark(int userChoice)
        {
            mark = Convert.ToInt32(userChoice == correctChoice);
            return mark;
        }
    }
}
