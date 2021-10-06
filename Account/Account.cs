using System;
using System.Collections.Generic;

namespace Logic
{
    public class Account
    {
        //FIELD
        public string NewAccount;
        public int AccountBalance;


        //METHOD
        public void CreateAccount(string newAccount)
        {
            NewAccount = newAccount;
        }

        public bool DepositMoney(int balance)
        {
            if (balance == 0)
            {
                return false;
            }

            AccountBalance = balance;
            return true;
        }

       


    }
}
