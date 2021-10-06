using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SavingsAccount : IPayer
    {
        private int _balance;

        public SavingsAccount(int balance)
        {
            _balance = balance;
        }

        public bool TryMakeWithdrawal(int amount)
        {
            bool canWithdrawal = amount <= _balance;

            if (canWithdrawal)
            {
                _balance -= amount;
            }

            return canWithdrawal;
        }

        

    }
}
