using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Age:");
            var age = Console.ReadLine();
            Console.WriteLine("Month born:");
            var monthBorn = Console.ReadLine();

            Console.WriteLine($"Name: {name} \nAge: {age} \nMonth born: {monthBorn}");
            if (monthBorn != null && monthBorn.ToLower() == "march")
            {
                Console.WriteLine($"You are an Aries");
            }
        }

        static void WriteTryAgain()
        {
            
        }
    }
}