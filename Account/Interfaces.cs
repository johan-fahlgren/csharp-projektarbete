using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IPayer
    {
        public bool TryMakeWithdrawal(int amount);
    }
    
    public interface IDeposit
    {
        public bool TryMakeDeposit(int amount);
    }

    public interface ICashDeposit
    {
        public bool TryMakeCashDeposit(int amount);
    }

}

  
