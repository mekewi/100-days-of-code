using System;
namespace Inheritance
{
    public class SavingAccount : BankAccount
    {
        #region Fields
        float interestRate;
        #endregion
        #region Constractor
        public SavingAccount(int deposite,float interestRate) : base(deposite)
        {
            this.interestRate = interestRate;
        }
        #endregion
        #region Methods
        public void AccrueInterest() 
        {
            balance += (int)(balance * interestRate);
        }
        #endregion

    }
}
