using System.Runtime.CompilerServices;

namespace Lab7
{
    internal static class Program
    {
        public static dynamic CreateProduct(string name,double price)
        {
            Product product = new Product { Name = name, Price = price };
            var anonymousProduct = new { Name = product.Name, Price = product.Price };
            return anonymousProduct;
        }

        public static int CountWords(this string sentence)
        {
            var words = sentence.Split(' ');
            return words.Length;
        }

        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static int GetAge(this DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            return age;
        }

        public static string ReverseString(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            var product = CreateProduct("Laptop", 999.99);
            Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}");

            string sentence = "Hello world from C# extension methods";
            int wordCount = sentence.CountWords();
            Console.WriteLine(wordCount);

            Console.WriteLine(42.IsEven());

            Console.WriteLine(new DateTime(2004, 3, 19).GetAge());

            Console.WriteLine("Hello".ReverseString());
        }
    }
}
