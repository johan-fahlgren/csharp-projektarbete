using System;
using Logic;
using Xunit;

namespace Tests
{
    public class AccountTests
    {

        //FIELD
        private readonly Account _account;


        [Fact]
        public void Test_CreateSavingsAccount()
        {
            bool newSavingsAccount = _account.NewAccount();
            
            Assert.True(newSavingsAccount);
        }
    }
}
