using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    internal static class Program
    {
        private static readonly List<Student> Students = new List<Student>();

        private static void Main(string[] args)
        {
            GetStudents();
            var addStudent = true;
            Console.WriteLine("Already imported students: ");
            var studentNumber = 0;
            foreach (var student in Students)
            {
                studentNumber += 1;
                Console.WriteLine($"Student {studentNumber} -> {student.Stringify()}");
            }

            if (Util.Console.AskString("Add another? Y/N").ToUpper() != "Y")
            {
                addStudent = false;
            }

            while (addStudent)
            {
                var newStudent = new Student();
                newStudent.Name = Util.Console.AskString("Student name: ");
                if (newStudent.Name.ToUpper() == "THIS")
                {
                    throw new Exception("IS SPARTA!!!");
                }

                newStudent.Grade = Util.Console.AskInt("Student grade: ");
                newStudent.Birthday = Util.Console.AskString("Student birthday: ");
                newStudent.Address = Util.Console.AskString("Student address: ");
                newStudent.SetPhone(Util.Console.AskInt("Student phone: "));
                newStudent.School = (School) (Util.Console.AskInt("School Name (select corresponding number): \n" +
                                                                  "1: Hogwarts \n" +
                                                                  "2: Harvard \n" +
                                                                  "3: MIT"
                ) - 1);
                Students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student count {0}", Student.Count);
                if (Util.Console.AskString("Add another? Y/N").ToUpper() != "Y")
                {
                    addStudent = false;
                }
            }

            studentNumber = 0;
            Console.WriteLine("Imported students: ");
            foreach (var student in Students)
            {
                studentNumber += 1;
                Console.WriteLine($"Student {studentNumber} -> {student.Stringify()}");
            }

            Exports();
        }

        private static void GetStudents()
        {
            Students.Add(new Student(
                "Jim",
                86,
                "Jun 13 1999",
                "123 Butterfly Lane",
                1234567,
                1
            ));
            Student.Count++;
        }

        private static void Exports()
        {
            foreach (var student in Students)
            {
                switch (student.School)
                {
                    case School.Hogwarts:
                        Console.WriteLine($"Exporting {student.Name} to Hogwarts");
                        break;
                    case School.Harvard:
                        Console.WriteLine($"Exporting {student.Name} to Harvard");
                        break;
                    default:
                        Console.WriteLine($"{student.Name} was not exported to any school");
                        break;
                }
            }
        }
    }

    internal enum School
    {
        Hogwarts,
        Harvard,
    }

    internal class Member
    {
        public string Name { get; set; }
        private string _address;
        protected int Phone;

        public string Address
        {
            set => _address = value + "";
            get => _address;
        }

        public void SetPhone(int number)
        {
            Phone = number;
        }

        public int GetPhone()
        {
            return Phone;
        }
    }

    internal class Student : Member
    {
        public static int Count;
        public int Grade { get; set; }
        public string Birthday { get; set; }
        public School School { get; set; }

        public Student()
        {
        }

        public Student(string name, int grade, string birthdate, string address, int phone, int school)
        {
            Name = name;
            Grade = grade;
            Birthday = birthdate;
            Address = address;
            SetPhone(phone);
            School = (School) school;
        }

        public string Stringify()
        {
            return $"Name: {Name}, " +
                   $"Grade: {Grade}, " +
                   $"Birthday: {Birthday}, " +
                   $"Address: {Address}, " +
                   $"Phone: {GetPhone()}, " +
                   $"School: {School}.";
        }
    }

    internal class Teacher : Member
    {
        public string Subject { get; set; }
    }
}