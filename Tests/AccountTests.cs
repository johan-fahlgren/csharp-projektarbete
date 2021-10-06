using System;
using System.Collections.Generic;
using Logic;
using Xunit;

namespace Tests
{
    public class AccountTests
    {
        
        //TESTS SAVINGS ACCOUNT
        [Fact]
        public void Test_DepositMoney()
        {

            SavingsAccount account = new SavingsAccount(0);

            //Deposit no money to account
            var depositMoney = account.TryMakeDeposit(0);
            Assert.False(depositMoney);

            //Deposit 1000 to account
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
