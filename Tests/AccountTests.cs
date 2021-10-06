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
    }
}
