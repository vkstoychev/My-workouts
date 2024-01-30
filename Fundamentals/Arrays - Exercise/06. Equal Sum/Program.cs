namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool equal = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum && !equal)
                {
                    Console.WriteLine(i);
                    equal = true;
                }
            }
            
            if (!equal)
            {
                Console.WriteLine("no");
            }
        }
    }
}
