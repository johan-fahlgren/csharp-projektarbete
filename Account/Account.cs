using System;
using System.Collections.Generic;

namespace Logic
{
    public abstract class Account : IPayer, IDeposit
    {
        protected int Balance;

        public bool TryMakeDeposit(int amount)
        {
            var newBalance = amount + Balance;

            if (newBalance > Balance)
            {
                return true;
            }

            return false;
        }


        public abstract bool TryMakeWithdrawal(int amount);

        protected Account(int balance)
        {
            Balance = balance;
        }
    }
}
