using System;
using System.Collections.Generic;

namespace Util
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

                
                newStudent.Name = Console.AskString("Student name: ");
                newStudent.Grade = Console.AskInt("Student grade: ");
                newStudent.Name = Console.AskString("Student birthday: ");
                newStudent.Name = Console.AskString("Student address: ");
                newStudent.SetPhone(Console.AskInt("Student phone: "));

                students.Add(newStudent);
                Student.Count++;
                System.Console.WriteLine("Student count {0}", Student.Count);

                if (Console.AskString("Add another? y/n") != "y")
                {
                    addStudent = false;
                }
            }

            var studentNumber = 0;

            foreach (var student in students)
            {
                studentNumber += 1;
                System.Console.WriteLine(
                    "Student {0} -> Name: {1}, Grade: {2}, Birthday: {3}, Address: {4}, Phone: {5}",
                    studentNumber, student.Name, student.Grade, student.Birthday, student.Address, student.GetPhone()
                );
            }
        }
    }

    class Student
    {
        public static int Count;
        public string Name { get; set; }
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        private int _phone;

        public int Phone
        {
            set { _phone = value; }
        }

        public void SetPhone(int number)
        {
            _phone = number;
        }

        public int GetPhone()
        {
            return _phone;
        }
    }
}