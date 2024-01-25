namespace _01._Factorial_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a non-negative integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int factorialResult = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialResult *= i;
            }
            // Add your code here to calculate the factorial of n

            Console.WriteLine($"Factorial of {n} is: {factorialResult}");
        }
    }
}
