using System;

namespace Util
{
    public class Console
    {
        public static string AskString(string question)
        {
            Ask(question);
            return Read();
        }

        public static int AskInt(string question)
        {
            Ask(question);
            return ReadInt();
        }

        private static void Ask(string question)
        {
            System.Console.WriteLine(question);
        }

        private static string Read()
        {
            var answer = System.Console.ReadLine();
            while (String.IsNullOrEmpty(answer))
            {
                System.Console.WriteLine("You didn't type anything, please try again.");
                return Read();
            }

            return answer;
        }

        private static int ReadInt()
        {
            try
            {
                return int.Parse(Read());
            }
            catch (Exception)
            {
                System.Console.WriteLine("Input was not a number, please try again.");
                return ReadInt();
            }
        }
    }
}