using System;
using System.Collections.Generic;
using Logic;
using Xunit;

namespace Tests
{
    public class AccountTests
    {

        //FIELD
        private readonly Account _account;

        //CONSTRUCTOR
        public AccountTests()
        {
            _account = new Account();
        }


        //TESTS SAVING ACCOUNTS
        [Fact]
        public void Test_CreateSavingsAccount()
        {
            _account.CreateAccount("savings_Account");
            
            Assert.Equal("savings_Account", _account.NewAccount);
        }


        [Fact]
        public void Test_AddCashToSavingsAccount()
        {

            bool noMoneyDeposit = _account.DepositMoney(0);
            bool newMoneyDeposit = _account.DepositMoney(1000);
            
            Assert.False(noMoneyDeposit);
            Assert.True(newMoneyDeposit);
        }


    }
}
