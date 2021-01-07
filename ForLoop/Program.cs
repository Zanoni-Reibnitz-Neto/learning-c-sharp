using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int mainLoop = 0; mainLoop < 5; mainLoop++)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i+1);
                }
                for (int i = 9; i > 0; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}