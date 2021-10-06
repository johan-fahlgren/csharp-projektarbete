using System;

namespace Tests
{
    public class CreditAccount
    {
        private int _balance;
        private int _credit;

        public CreditAccount(int balance, int credit)
        {
            _balance = balance;
            _credit = credit;
        }

        public int AccountBalance()
        {
            return _balance + _credit;
        }

        public bool TryMakePayment(int amount)
        {
            bool canMakePayment = amount <= AccountBalance();

            if (canMakePayment)
            {
                if (_balance < amount)
                {
                    amount -= _balance;
                    _balance = 0;

                    _credit -= amount;
                }
                else
                {
                    _balance -= amount;
                }
            }
            
            return canMakePayment;
        }
    }
}