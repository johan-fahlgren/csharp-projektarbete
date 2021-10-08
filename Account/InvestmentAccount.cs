using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class InvestmentAccount : Account
    {
        
        
        public InvestmentAccount(int balance, DateTime dateTime) :base(balance)
        {
            Balance = balance;
            DateTime = dateTime;
        }
        
        public override bool TryMakeWithdrawal(int amount)
        {
            if (!CheckDateWithdrawal())
            {
                return false;
            }

            var canWithdrawal = amount <= Balance;

            if (canWithdrawal)
            {
                Balance -= amount;
            }

            return canWithdrawal;
        }
        
    }
}
