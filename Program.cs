using System;

namespace Enhancedloop
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] fibnum = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            int count = 0;
            foreach(int x in fibnum)
            {
                count++;
                Console.WriteLine($"{x}:{count}");
               

            }
            Console.WriteLine($"There are {count} numbers");

        }
    }
}
