namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] train = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                train[i] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine(string.Join(' ', train));
            Console.WriteLine(train.Sum());
        }
    }
}