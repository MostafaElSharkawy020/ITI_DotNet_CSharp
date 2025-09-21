namespace Lab5_6
{
    static class Helper
    {
        public static void BubbleSort<T>(T[] array) where T : IComparable<T>
        {
            int n = array.Length;
            bool isSorted = true;
            for (int i = 0; i < n - 1; i++)
            {
                isSorted = true;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted) break;
            }
        }

        public static void ReverseArrayList<T>(List<T> list)
        {
            int n = list.Count;
            for (int i = 0; i < n / 2; i++)
            {
                T temp = list[i];
                list[i] = list[n - i - 1];
                list[n - i - 1] = temp;
            }
        }

        public static int FindFirstNonRepeatingChar(string str)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount.ContainsKey(str[i]))
                    charCount[str[i]]++;
                else
                    charCount[str[i]] = 1;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                    return i;
            }
            return -1;
        }

    }
}
