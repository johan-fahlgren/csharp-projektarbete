using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class InvestmentAccount : Account
    {
        public DateTime _dateTime;
        
        public InvestmentAccount(int balance, DateTime dateTime) :base(balance)
        {
            Balance = balance;
            _dateTime = dateTime;
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
        public bool CheckDateWithdrawal()
        {
            var dateNotOK = DateTime.Today + TimeSpan.FromDays(365);
            
            var dateOK = _dateTime <= dateNotOK;
            
            if (dateOK)
            {
                return true;
            }

            return false;
        }
    }
}
