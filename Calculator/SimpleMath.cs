using System.Windows;

namespace Calculator
{
    public static class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divide(double n1, double n2)
        {
            if (n2 == 0)
            {

                MessageBox.Show("Divide by zero not allowed!", "Wrong Operation", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            return n1 / n2;
        }
    }
}
