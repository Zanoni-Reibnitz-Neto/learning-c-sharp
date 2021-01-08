using System;

namespace SchoolTracker
{
    internal class Teacher : Member, IPayee
    {
        public string Subject { get; set; }

        public void Pay()
        {
            Console.WriteLine("Paying teacher");
        }
    }
}