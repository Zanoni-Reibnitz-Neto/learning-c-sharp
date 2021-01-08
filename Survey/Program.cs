using Util;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Name = Console.AskString("What is your name?");
            customer.Age = Console.AskInt("How old are you?");
            customer.BirthMonth = Console.AskString("What month were you born?");
            System.Console.WriteLine("------------------");
            System.Console.WriteLine(customer.Stringify());
        }

        private static string ConsoleRead()
        {
            var answer = System.Console.ReadLine();
            if (answer == "")
            {
                System.Console.WriteLine("You didn't type anything, please try again.");
                return ConsoleRead();
            }

            return answer;
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