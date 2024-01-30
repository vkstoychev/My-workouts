namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] first = new int[lines];
            int[] second = new int[lines];

            bool isFirst = true;

            for (int i = 0; i < lines; i++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int number1 = line[0];
                int number2 = line[1];

                if (isFirst)
                {
                    first[i] = number1;
                    second[i] = number2;
                }

                else
                {
                    second[i] = number1;
                    first[i] = number2;
                }

                isFirst = !isFirst;
            }

            Console.WriteLine(string.Join(' ', first));
            Console.WriteLine(string.Join(' ', second));
        }
    }
}
