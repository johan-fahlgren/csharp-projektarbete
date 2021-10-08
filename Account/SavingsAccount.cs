using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(int balance) : base(balance)
        {

        }
        //METHODS
        public override bool TryMakeWithdrawal(int amount)
        {
            var canWithdrawal = amount <= Balance;

            if (canWithdrawal)
            {
                Balance -= amount;
            }

            return canWithdrawal;
        }
        
        public int AccountBalance()
        {
            return Balance;
        }


    }
}
