using System;
using System.Linq;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsGrades = new int[] {32, 12};

            studentsGrades[1] = 23;
            
            foreach (var grade in studentsGrades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}