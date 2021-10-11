using System;
using System.Collections.Generic;

namespace Logic
{
    public abstract class Account : IPayer, IDeposit
    {
        protected int Balance;
        public DateTime DateTime;
        protected Account(int balance)
        {
            Balance = balance;
        }

        public bool TryMakeDeposit(int amount)
        {
            var newBalance = amount + Balance;

            if (amount <= 15000)
            {
                if (newBalance > Balance)
                {
                    return true;
                }
            }
            
            return false;
        }

        public virtual bool TryMakeWithdrawal(int amount)
        {
            var canWithdrawal = amount <= Balance;

            if (canWithdrawal)
            {
                Balance -= amount;
            }

            return canWithdrawal;
        }
        public virtual int AccountBalance()
        {
            return Balance;
        }
        public bool CheckDateWithdrawal()
        {
            var dateNotOK = DateTime.Today + TimeSpan.FromDays(365);

            var dateOK = DateTime <= dateNotOK;

            if (dateOK)
            {
                return true;
            }

            return false;
        }


    }
}
