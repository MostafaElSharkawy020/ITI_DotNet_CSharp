namespace Lab3
{
    class Question
    {
        public string header { get; set; }
        public string body { get; set; }
        public int mark { get; set; }

        public Question()
        {
            this.header = "Default Header";
            this.body = "Default Body";
            this.mark = 0;
        }

        public Question(string header, string body)
        {
            this.header = header;
            this.body = body;
            this.mark = 0;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Header: {header}");
            Console.WriteLine($"Body: {body}");
        }
    }
}
