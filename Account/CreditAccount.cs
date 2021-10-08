using System;
using Logic;

namespace Tests
{
    public class CreditAccount : Account
    {
        private int _credit;

        public CreditAccount(int balance, int credit) :base (balance)
        {
            _credit = credit;
        }

        public override int AccountBalance()
        {
            return Balance + _credit;
        }

        public override bool TryMakeWithdrawal(int amount)
        {
            bool canMakePayment = amount <= AccountBalance();

            if (canMakePayment)
            {
                if (Balance < amount)
                {
                    amount -= Balance;
                    Balance = 0;

                    _credit -= amount;
                }
                else
                {
                    Balance -= amount;
                }
            }
            
            return canMakePayment;
        }
    }
}