using System;
using Survey;

namespace SurveyChallenge
{
    internal class Stats
    {
        public static void Start()
        {
            Program.Posted += HasPosted;
        }

        private static void HasPosted()
        {
            Console.WriteLine("Survey posted, run stats");
        }
    }
}