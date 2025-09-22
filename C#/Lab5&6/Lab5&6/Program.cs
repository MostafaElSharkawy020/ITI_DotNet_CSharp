namespace Lab5_6
{
    internal class Program
    {
        static void Task1Demo()
        {
            Console.WriteLine("Task 1:");
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
            Helper.BubbleSort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
            Console.WriteLine();
        }
        static void Task4Demo()
        {
            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = ints.FindAll(x => x % 2 == 0);
            Console.WriteLine("Task 4:");
            Console.WriteLine("Original list: " + string.Join(", ", ints));
            Console.WriteLine("Even numbers: " + string.Join(", ", result));
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Task1Demo();
            Task4Demo();
        }
    }
}
