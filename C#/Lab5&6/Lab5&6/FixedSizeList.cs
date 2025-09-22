namespace Lab5_6
{
    class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        public FixedSizeList(int size)
        {
            items = new T[size];
            count = 0;
        }
        public void Add(T item)
        {
            if (count < items.Length)
            {
                items[count] = item;
                count++;
            }
            else
            {
                throw new System.InvalidOperationException("List is full");
            }
        }
        public T Get(int index)
        {
            if (index >= 0 && index < count)
            {
                return items[index];
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("Index out of range");
            }
        }
    }
}
