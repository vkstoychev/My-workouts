namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialBugsIndex = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[fieldSize];

            for (int i = 0; i < initialBugsIndex.Length; i++)
            {
                int currentBugIndex = initialBugsIndex[i];
                if (-1 < currentBugIndex || currentBugIndex < fieldSize - 1)
                    continue;

                field[currentBugIndex] = 1;
            }

            //Console.WriteLine(string.Join(' ', field));


            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] bugFly = Console.ReadLine().Split();

                int bugIndex = int.Parse(bugFly[0]);
                string bugDirection = bugFly[1];
                int bugFlySpeed = int.Parse(bugFly[2]);

                if (-1 < bugIndex || bugIndex < fieldSize)
                    continue;

                else
                {
                    if ()
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', field));



        }
    }
}
