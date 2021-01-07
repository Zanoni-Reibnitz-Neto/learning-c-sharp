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

                Console.WriteLine("Student name: ");
                newStudent.Name = ConsoleInterface.ReadString();
                Console.WriteLine("Student grade: ");
                newStudent.Grade = ConsoleInterface.ReadInt();
                Console.WriteLine("Student birthday: ");
                newStudent.Birthday = ConsoleInterface.ReadString();
                Console.WriteLine("Student address: ");
                newStudent.Address = ConsoleInterface.ReadString();
                Console.WriteLine("Student phone: ");
                newStudent.SetPhone(ConsoleInterface.ReadInt());

                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student count {0}", Student.Count);

                Console.WriteLine("Add another? y/n");
                if (ConsoleInterface.ReadString() != "y")
                {
                    addStudent = false;
                }
            }

            var studentNumber = 0;

            foreach (var student in students)
            {
                studentNumber += 1;
                Console.WriteLine(
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