using System;
using System.Collections.Generic;

namespace Logic
{
    public abstract class Account : IPayer, IDeposit, ICashDeposit
    {
        protected int Balance;
        public DateTime DateTime;
        public DateTime TooBigDepositDate;

        public DateTime CurrentDate { get; set; }

        protected Account(int balance)
        {
            Balance = balance;
            CurrentDate = DateTime.Today;
        }

        public bool TryMakeDeposit(int amount)
        {
            var newBalance = amount + Balance;

            if (newBalance > Balance)
            {
                return true;
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

        public bool TryMakeCashDeposit(int amount)
        {
            if (amount > 15000)
            {
                return false;
            }
            else if (HasMadeMaxCashDepositToday())
            {
                return false;
            }
            else if (amount == 15000)
            {
                TooBigDepositDate = CurrentDate;

            }

            Balance += amount;
            return true;
        }

        public bool HasMadeMaxCashDepositToday()
        {
            if (TooBigDepositDate == DateTime.MinValue)
            {
                return false;
            }
            else if (TooBigDepositDate + TimeSpan.FromDays(1) <= CurrentDate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
