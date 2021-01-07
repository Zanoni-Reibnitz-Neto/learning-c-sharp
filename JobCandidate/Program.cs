using System;

namespace JobCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have!");
            var years = int.Parse(ConsoleRead());
            switch (years)
            {
                case 0:
                    Console.WriteLine("Inexperience");
                    break;
                case 1:
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;
            }
        }

        private static string ConsoleRead()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You didn't type anything, please try again.");
                return ConsoleRead();
            }

            return answer;
        }
    }
}