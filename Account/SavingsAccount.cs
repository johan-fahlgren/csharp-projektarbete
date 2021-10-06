using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SavingsAccount : IPayer, IDeposit
    {
        private int _balance;

        public SavingsAccount(int balance)
        {
            _balance = balance;
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

        public bool TryMakeDeposit(int amount)
        {
           var newBalance = amount + _balance;

           if (newBalance > _balance)
           {
               return true;
           }

           return false;
        }



    }
}
