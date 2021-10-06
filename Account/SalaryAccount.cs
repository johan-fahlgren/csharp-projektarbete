using System;
using Logic;

namespace Tests
{
    public class SalaryAccount : IDeposit
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
    }
}