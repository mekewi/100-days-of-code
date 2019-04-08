using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class CheckingAcount : BankAccount
    {
        #region Fields
        private List<int> checks = new List<int>();
        #endregion
        #region Properties
        public List<int> Checks { get { return checks; } }
        #endregion
        #region Constractor
        public CheckingAcount(int initialDeposite):base(initialDeposite)
        {
        }
        #endregion
        #region Methods
        public void CashCheck(int amount) 
        {
            if (amount <= balance)
            {
                balance -= amount;
                checks.Add(amount);
            }
            else
            {
                Console.WriteLine("Not enough money in account to cover check");
            }
        }
        #endregion

    }
}
