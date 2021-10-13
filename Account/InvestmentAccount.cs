using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class InvestmentAccount : Account
    {
        public DateTime LastWithdrawalDate;

        public InvestmentAccount(int balance) :base(balance)
        {
            Balance = balance;
        }
        
        public override bool TryMakeWithdrawal(int amount)
        {
            if (HasMadeWithdrawalThisYear())
            {
                return false;
            }

            var canWithdrawal = amount <= Balance;

            if (canWithdrawal)
            {
                Balance -= amount;
                LastWithdrawalDate = CurrentDate;
            }

            return canWithdrawal;
        }
        public bool HasMadeWithdrawalThisYear()
        {
            if (LastWithdrawalDate == DateTime.MinValue)
            {
                return false;
            }
            else if (LastWithdrawalDate + TimeSpan.FromDays(365) <= CurrentDate)
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
