namespace Lab3
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new System.DivideByZeroException("Denominator cannot be zero.");
            }
            return a / b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0.0)
            {
                throw new System.DivideByZeroException("Denominator cannot be zero.");
            }
            return a / b;
        }
    }
}
