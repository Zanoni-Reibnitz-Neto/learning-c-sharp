using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = ConsoleRead();
            Console.WriteLine("How old are you?");
            var age = ConsoleRead();
            Console.WriteLine("What month were you born?");
            var monthBorn = ConsoleRead();

            Console.WriteLine($"Name: {name} \nAge: {age} \nMonth born: {monthBorn}");
            if (monthBorn != null && monthBorn.ToLower() == "march")
            {
                Console.WriteLine($"You are an Aries");
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