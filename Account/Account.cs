using System;
using System.Collections.Generic;

namespace Logic
{
    public class Account
    {
        //FIELD
        public string NewAccount;
        

        //METHOD
        public void CreateAccount(string newAccount)
        {
            NewAccount = newAccount;
        }

        public bool DepositMoney()
        {
            throw new NotImplementedException();
        }
    }
}
