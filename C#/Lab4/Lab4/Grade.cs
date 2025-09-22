namespace Lab4
{
    class Grade
    {
        public double Value { get; set; }
        public Grade(double value)
        {
            Value = value;
        }
        public Grade()
        {
            Value = 0;
        }
        public static Grade operator +(Grade g1, Grade g2)
        {
            return new Grade { Value = g1.Value + g2.Value };
        }
        public static bool operator ==(Grade g1, Grade g2)
        {
            return g1.Value == g2.Value;
        }
        public static bool operator !=(Grade g1, Grade g2)
        {
            return g1.Value != g2.Value;
        }
    }
}
