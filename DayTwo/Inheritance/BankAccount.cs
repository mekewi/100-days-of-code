using System;
using System.Collections.Generic;

namespace Inheritance
{
    public class BankAccount
    {
        #region Fields

        protected int balance;
        private List<int> deposits = new List<int>();
        private List<int> withdrawals = new List<int>();

        #endregion

        #region Properties
        public int Balance { get { return balance; } }
        public List<int> Deposits { get { return deposits; } }
        public List<int> Withdrawals { get { return withdrawals; } }

        #endregion

        #region Constractor
        public BankAccount(int initialDeposite)
        {
            balance = initialDeposite;
            deposits.Add(initialDeposite);
        }
        #endregion

        #region Methods

        public void MakeDeposite(int amount)
        {
            if (amount > 0)
            {
                balance += amount;
                deposits.Add(amount);
            }
            else
            {
                Console.WriteLine("Deposite Most Be larger than 0");
            }
        }

        public void MakeWithdrawal(int amount) {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;
                withdrawals.Add(amount);
            }else
            {
                Console.WriteLine("Not enough money for withdrawal amount");
            }
        }
        public override string ToString()
        {
            return "Balance : " + Balance;
        }
        #endregion
    }
}
