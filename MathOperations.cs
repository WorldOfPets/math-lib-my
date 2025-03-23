namespace ClassLibrary1
{
    public class MathOperations
    {
        // Addition
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Division
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double)a / b;
        }
    }
}