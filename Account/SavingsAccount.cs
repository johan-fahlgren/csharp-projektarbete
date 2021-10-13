using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(int balance) : base(balance) {}

        public bool TakeWithdrawalFee(int fee)
        {
            throw new NotImplementedException();
        }
    }
}
