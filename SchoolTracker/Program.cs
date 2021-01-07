using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var addStudent = true;

            while (addStudent)
            {
                var newStudent = new Student();

                Console.WriteLine("Student name: "); newStudent.Name = ConsoleInterface.ReadString();
                Console.WriteLine("Student grade: "); newStudent.Grade = ConsoleInterface.ReadInt();
                Console.WriteLine("Student birthday: "); newStudent.Birthday = ConsoleInterface.ReadString();
                Console.WriteLine("Student address: "); newStudent.Address = ConsoleInterface.ReadString();
                Console.WriteLine("Student phone: "); newStudent.Phone = ConsoleInterface.ReadInt();

                students.Add(newStudent);

                Console.WriteLine("Add another? y/n");
                if (ConsoleInterface.ReadString() != "y")
                {
                    addStudent = false;
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public int Phone { set; get; }
    }
}