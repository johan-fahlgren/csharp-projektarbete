using System;
using Logic;

namespace Tests
{
    public class SalaryAccount : Account
    {

        public SalaryAccount(int balance) :base(balance)
        { 

        }

        public bool TryMakeWithdrawal(int amount)
        {
            var canWithdrawal = amount <= Balance;

            if (canWithdrawal)
            {
                Balance -= amount;
            }

            return canWithdrawal;
        }
    }
}