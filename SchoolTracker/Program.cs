using System.Collections.Generic;
using Util;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = GetStudents();
            var addStudent = true;
            System.Console.WriteLine("Already imported students: ");
            var studentNumber = 0;
            foreach (var student in students)
            {
                studentNumber += 1;
                System.Console.WriteLine($"Student {studentNumber} -> {student.Stringify()}");
            }
            if (Console.AskString("Add another? y/n") != "y") { addStudent = false; }
            while (addStudent)
            {
                var newStudent = new Student();
                newStudent.Name = Console.AskString("Student name: ");
                newStudent.Grade = Console.AskInt("Student grade: ");
                newStudent.Birthday = Console.AskString("Student birthday: ");
                newStudent.Address = Console.AskString("Student address: ");
                newStudent.SetPhone(Console.AskInt("Student phone: "));
                students.Add(newStudent);
                Student.Count++;
                System.Console.WriteLine("Student count {0}", Student.Count);
                if (Console.AskString("Add another? y/n") != "y") { addStudent = false; }
            }
            studentNumber = 0;
            System.Console.WriteLine("Imported students: ");
            foreach (var student in students)
            { studentNumber += 1; System.Console.WriteLine($"Student {studentNumber} -> {student.Stringify()}"); }
        }

        private static List<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student(
                "Jim",
                86,
                "Jun 13 1999",
                "123 Butterfly Lane",
                1234567
            ));
            Student.Count++;
            return students;
        }
    }

    class Member
    {
        public string Name { get; set; }
        private string _address;
        protected int Phone;

        public string Address
        {
            set { _address = value; }
            get { return _address; }
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

    class Student : Member
    {
        public static int Count;
        public int Grade { get; set; }
        public string Birthday { get; set; }

        public Student()
        {
        }

        public Student(string name, int grade, string birthdate, string address, int phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthdate;
            Address = address;
            SetPhone(phone);
        }

        public string Stringify()
        {
            return $"Name: {Name}, " +
                   $"Grade: {Grade}, " +
                   $"Birthday: {Birthday}, " +
                   $"Address: {Address}, " +
                   $"Phone: {GetPhone()}";
        }
    }

    class Teacher : Member
    {
        public string Subject { get; set; }
    }
}