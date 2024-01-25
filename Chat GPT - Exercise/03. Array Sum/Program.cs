namespace _03._Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            // Declare an array with n elements
            int[] array = new int[n];

            // Input values for each element of the array
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter a value for element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Calculate the sum of the elements in the array
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }

            // Output the sum
            Console.WriteLine($"The sum of the elements in the array is: {sum}");
        }
    }
}
