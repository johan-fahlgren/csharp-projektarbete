using System;
using System.Collections.Generic;
using Logic;
using Xunit;

namespace Tests
{
    public class AccountTests
    {
        
        // TESTS SAVINGS ACCOUNT
        [Fact]
        public void Test_DepositMoney()
        {

            SavingsAccount account = new SavingsAccount(0);

            // Deposit no money to account
            var depositMoney = account.TryMakeDeposit(0);
            Assert.False(depositMoney);

            // Deposit 1000 to account
            depositMoney = account.TryMakeDeposit(1000);
            Assert.True(depositMoney);
            
        }


        [Fact]
        public void Test_MakeWithdrawal()
        {
            SavingsAccount account = new SavingsAccount(1000);

            // Withdrawal with money left
            var withdrawalMoney = account.TryMakeWithdrawal(250);
            Assert.True(withdrawalMoney);

            // Overdraft withdrawal
            withdrawalMoney = account.TryMakeWithdrawal(800);
            Assert.False(withdrawalMoney);
        }

        [Fact]
        public void Test_TryWithdrawalFiveTimesThenAddFee()
        {
            SavingsAccount account = new SavingsAccount(5000);
            
            int amount = 500;

            for (int trys = 1; trys <= 6; trys++)
            {
                // Try 5 withdrawals
                if (trys <= 5)
                {
                    var withdrawalMoney = account.TryMakeWithdrawal(amount);
                }
                // Add 1% fee after 5 withdrawals
                else
                {
                    int fee = (amount/100) + amount;
                    
                    var withdrawalFee = account.TryMakeWithdrawal(fee);
                    
                    Assert.Equal(1995, account.AccountBalance());
                }
            }
        }

        [Fact]
        public void Test_DepositSalaryAccount()
        {
            SalaryAccount account = new SalaryAccount(0);

            bool depositNoMoney = account.TryMakeDeposit(0);

            Assert.False(depositNoMoney);

            bool depositMoney = account.TryMakeDeposit(15000);

            Assert.True(depositMoney);

        }

        [Fact]
        public void Test_WithdrawalAndOverdraft()
        {
            SalaryAccount account = new SalaryAccount(5000);

            bool withdrawalMoney = account.TryMakeWithdrawal(1000);

            Assert.True(withdrawalMoney);

            bool withdrawalTooMuchMoney = account.TryMakeWithdrawal(5000);

            Assert.False(withdrawalTooMuchMoney);
            
        }

        [Fact]
        public void Test_CreateCreditAccount()
        {
            CreditAccount account = new CreditAccount(5000,20000);
            
            Assert.Equal(25000, account.AccountBalance());
        }

        [Fact]
        public void Test_OverdraftBalanceAndUseCredit()
        {
            CreditAccount account = new CreditAccount(5000, 20000);

            bool makePayment = account.TryMakePayment(10000);

            Assert.True(makePayment);

            Assert.Equal(15000, account.AccountBalance());


        }
    }
}
