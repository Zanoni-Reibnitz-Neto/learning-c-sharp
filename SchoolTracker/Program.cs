using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var studentCount = ConsoleInterface.ReadInt();

            var studentsNames = new string[studentCount];
            var studentsGrades = new int[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student name: ");
                studentsNames[i] = ConsoleInterface.ReadString();
                Console.WriteLine("Student grade: ");
                studentsGrades[i] = ConsoleInterface.ReadInt();
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentsNames[i], studentsGrades[i]);
            }
        }
    }
}