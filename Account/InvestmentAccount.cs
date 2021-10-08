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

        public InvestmentAccount(int balance)
        {
            _balance = balance;
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
            throw new NotImplementedException();
        }

    }
}
