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


        //TESTS SAVINGS ACCOUNT
        [Fact]
        public void Test_CreateSavingsAccount()
        {
           
            _account.CreateAccount("savings_Account");
            

            Assert.Equal("savings_Account", _account.NewAccount);

        }


        [Fact]
        public void Test_DepositMoney()
        {

            SavingsAccount account = new SavingsAccount(0);

            var depositMoney = account.TryMakeDeposit(0);
            Assert.False(depositMoney);

            depositMoney = account.TryMakeDeposit(1000);
            Assert.True(depositMoney);

            
        }

        [Fact]
        public void Test_MakeWithdrawal()
        {
            SavingsAccount account = new SavingsAccount(1000);

            //Withdrawal with money left
            var withdrawalMoney = account.TryMakeWithdrawal(250);
            Assert.True(withdrawalMoney);

            //Overdraft withdrawal
            withdrawalMoney = account.TryMakeWithdrawal(800);
            Assert.False(withdrawalMoney);
        }

    }
}
