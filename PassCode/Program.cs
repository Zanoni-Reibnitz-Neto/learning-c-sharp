using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "dsa";

            while (code != null && code.ToLower() != "secret")
            {
                Console.WriteLine("Pass code:");
                code = Console.ReadLine();

                if (code != null && code.ToLower() == "secret")
                {
                    Console.WriteLine($"Authenticated");
                }
                else
                {
                    Console.WriteLine($"Not authenticated");
                }
            }
        }
    }
}