namespace Lab5_6
{
    class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min,T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("min should be less than or equal to max");
            this.Min = min;
            this.Max = max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public T Length()
        {
            return (dynamic)Max - (dynamic)Min;
        }
    }
}
