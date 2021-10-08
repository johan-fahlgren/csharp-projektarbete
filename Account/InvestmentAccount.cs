using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class InvestmentAccount : IDeposit
    {
        private int _balance;
        public DateTime _dateTime;

        public InvestmentAccount(int balance, DateTime dateTime)
        {
            _balance = balance;
            _dateTime = dateTime;
        }

        
        public bool TryMakeDeposit(int amount)
        {
            var canDeposit = amount + _balance;

            if (canDeposit >= _balance)
            {
                return true;
            }

            return false;
        }

        public bool TryMakeWithdrawal(int amount)
        {
            if (!CheckDateWithdrawal())
            {
                return false;
            }

            var canWithdrawal = amount <= _balance;

            if (canWithdrawal)
            {
                _balance -= amount;
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
