using System.Collections.Generic;

namespace SchoolTracker
{
    internal interface IPayee
    {
        void Pay();
    }

    internal class Payroll
    {
        List<IPayee> payees = new List<IPayee>();
        public Payroll()
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());

            Logger.Log("Payroll started", "Payroll");
        }
        public void PayAll()
        {
            foreach (var payee in payees)
            {
                payee.Pay();
            }

            Logger.Log("PayAll completed","PayRole", 2);
        }
    }
}
