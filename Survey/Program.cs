using System;
using SurveyChallenge;
using Console = Util.Console;

namespace Survey
{
    internal static class Program
    {
        public static event Action Posted;

        private static void Main(string[] args)
        {
            var stats = new Stats();
            Stats.Start();
            var customer = new Customer
            {
                Name = Console.AskString("What is your name?"),
                Age = Console.AskInt("How old are you?"),
                BirthMonth = Console.AskString("What month were you born?")
            };
            Posted?.Invoke();
            System.Console.WriteLine(customer.Stringify());
        }

        private static string ConsoleRead()
        {
            while (true)
            {
                var answer = System.Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(answer)) return answer;
                System.Console.WriteLine("You didn't type anything, please try again.");
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string BirthMonth { get; set; }

        public string Stringify()
        {
            var stringValue =
                $"Your name is: {Name}\n" +
                $"Your age is: {Age}\n" +
                $"Your birth month is: {BirthMonth}\n";
            switch (BirthMonth.ToUpper())
            {
                case "MARCH":
                    stringValue += "You are an Arias.";
                    break;
                case "APRIL":
                    stringValue += "You are a Taurus.";
                    break;
                case "MAY":
                    stringValue += "You are a Gemini.";
                    break;
            }

            return stringValue;
        }
    }
}