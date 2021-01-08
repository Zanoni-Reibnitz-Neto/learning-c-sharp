using System.Collections.Generic;

namespace SchoolTracker
{
    internal interface IPayee
    {
        void Pay();
    }

    internal class Payroll
    {
        private readonly List<IPayee> _payees = new List<IPayee>();
        public Payroll()
        {
            _payees.Add(new Teacher());
            _payees.Add(new Teacher());
            _payees.Add(new Principal());

            Logger.Log("Payroll started", "Payroll");
        }
        public void PayAll()
        {
            foreach (var payee in _payees)
            {
                payee.Pay();
            }

            Logger.Log("PayAll completed","Payroll", 2);
        }
    }
}
