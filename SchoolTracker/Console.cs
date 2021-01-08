using System;

namespace Util
{
    public static class Console
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

        private static void Ask(int question)
        {
            System.Console.WriteLine(question);
        }

        private static string Read()
        {
            var answer = System.Console.ReadLine();
            while (string.IsNullOrEmpty(answer))
            {
                System.Console.WriteLine("You didn't type anything, please try again: ");
                return Read();
            }

            return answer;
        }

        private static int ReadInt()
        {
            try
            {
                return Math.Abs(Read().ToInt());
            }
            catch (Exception exception)
            {
                System.Console.WriteLine(exception.Message + " It must be a number, please try again: ");
                return ReadInt();
            }
        }
    }

    public static class ExtensionMethods
    {
        public static int ToInt(this string value)
        {
            return int.Parse(value);
        }
    }
}