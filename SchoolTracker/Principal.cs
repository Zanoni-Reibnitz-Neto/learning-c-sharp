using System;

namespace SchoolTracker
{
    public class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying principal");
        }
    }
}