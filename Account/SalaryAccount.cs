using System;
using Logic;

namespace Tests
{
    public class SalaryAccount : IDeposit, IPayer
    {
        private int _balance;
        
        public SalaryAccount(int balance)
        {
            _balance = balance;
        }

        public bool TryMakeDeposit(int amount)
        {
            var canDeposit = amount + _balance;

            if (canDeposit > _balance)
            {
                return true;
               
            }

            return false;
        }

        public bool TryMakeWithdrawal(int amount)
        {
            var canWithdrawal = amount <= _balance;

            if (canWithdrawal)
            {
                _balance -= amount;
            }

            return canWithdrawal;
        }
    }
}