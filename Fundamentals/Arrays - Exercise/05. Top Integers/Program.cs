namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                bool isTop = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int compareNumber = numbers[j];

                    if (compareNumber >= currentNumber)
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write($"{currentNumber} ");
                }
            }
        }
    }
}
