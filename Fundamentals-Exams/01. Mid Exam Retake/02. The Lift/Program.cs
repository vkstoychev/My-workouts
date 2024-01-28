using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int tourists = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    if (tourists >= 4 - lift[i])
                    {
                        tourists -= 4 - lift[i];
                        lift[i] = 4;
                    }
                    else
                    {
                        lift[i] += tourists;
                        tourists = 0;
                    }
                }
            }

            bool isNotFull = false;

            for (int i = 0; i < lift.Length; i++)
            {
                if (lift[i] < 4)
                {
                    isNotFull = true;
                    break;
                }
            }

            if (tourists == 0 && isNotFull)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (tourists > 0 && !isNotFull)
            {
                Console.WriteLine($"There isn't enough space! {tourists} people in a queue!");
            }

            Console.WriteLine(String.Join(" ", lift));
        }
    }
}

