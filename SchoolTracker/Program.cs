using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsNames = new List<string>();
            var studentsGrades = new List<int>();

            var addStudent = true;
            
            while (addStudent)
            {
                Console.WriteLine("Student name: ");
                studentsNames.Add(ConsoleInterface.ReadString());
                Console.WriteLine("Student grade: ");
                studentsGrades.Add(ConsoleInterface.ReadInt());
                
                Console.WriteLine("Add another? y/n");
                if (ConsoleInterface.ReadString() != "y")
                {
                    addStudent = false;
                }
            }

            for (int i = 0; i < studentsNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentsNames[i], studentsGrades[i]);
            }
        }
    }
}