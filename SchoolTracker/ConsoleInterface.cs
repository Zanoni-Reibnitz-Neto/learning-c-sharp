using System;

namespace SchoolTracker
{
    public class ConsoleInterface
    {
        public static string ReadString()
        {
            var answer = Console.ReadLine();
            if (String.IsNullOrEmpty(answer))
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return ReadString();
            }

            return answer;
        }

        public static int ReadInt()
        {
            var answer = Console.ReadLine();
            if (String.IsNullOrEmpty(answer))
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return ReadInt();
            }

            try
            {
                return int.Parse(answer);
            }
            catch (Exception)
            {
                Console.WriteLine("Input was not a number, please try again.");
                return ReadInt();
            }
        }
    }
}