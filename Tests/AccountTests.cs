using System;
using System.Collections.Generic;
using Logic;
using Xunit;

namespace Tests
{
    public class AccountTests
    {
        //FIELDS
        private DateTime todaysDate = DateTime.Today;
        private int maxCredit = 20000;

        // TESTS SAVINGS ACCOUNT
        [Fact]
        public void Test_DepositMoney()
        {
            SavingsAccount account = new SavingsAccount(0);

            // Deposit no money to account
            var depositNoMoney = account.TryMakeDeposit(0);
            Assert.False(depositNoMoney);

            // Deposit 1000 to account
            var depositMoney = account.TryMakeDeposit(1000);
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
        // Test Salary Account
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

        // Test Credit Account
        [Fact]
        public void Test_CreateCreditAccount()
        {
            CreditAccount account = new CreditAccount(5000,maxCredit);
            
            Assert.Equal(25000, account.AccountBalance());
        }

        [Fact]
        public void Test_OverdraftBalanceAndUseCredit()
        {
            CreditAccount account = new CreditAccount(5000, maxCredit);

            bool makePayment = account.TryMakeWithdrawal(10000);

            Assert.True(makePayment);

            Assert.Equal(15000, account.AccountBalance());
        }

        [Fact]
        public void Test_OverdraftCredit()
        {
            CreditAccount account = new CreditAccount(5000,maxCredit);

            bool overCreditPayment = account.TryMakeWithdrawal(30000);

            Assert.False(overCreditPayment);
        }

        //TEST INVESTMENT ACCOUNT

        [Fact]
        public void Test_DepositMoneyInvestmentAccount()
        {

            InvestmentAccount account = 
                new InvestmentAccount(500, todaysDate);

            bool depositMoney = account.TryMakeDeposit(5000);

            Assert.True(depositMoney);
        }

        [Fact]
        public void Test_WithdrawalMoneyInvestmentAccount()
        {
            InvestmentAccount account = 
                new InvestmentAccount(5500, todaysDate);

            //Withdrawal
            bool withdrawalMoney = 
                account.TryMakeWithdrawal(4000);

            Assert.True(withdrawalMoney);

            //Overdraft
            bool withdrawalToMuchMoney =
                account.TryMakeWithdrawal(2000);

            Assert.False(withdrawalToMuchMoney);
        }

        [Fact]
        public void Test_OnlyOneWithdrawalPerYearInvestmentAccount()
        {
            InvestmentAccount account = 
                new InvestmentAccount(5000, todaysDate);

            //Withdrawal today
            bool withdrawalMoneyToday = 
                account.TryMakeWithdrawal(1000);

            Assert.True(withdrawalMoneyToday);

            
            // Withdrawal plus one year from now
            var newDate = account.DateTime = todaysDate + TimeSpan.FromDays(369);

            bool withdrawalMoneyPlusOneYear =
                account.TryMakeWithdrawal(1000);

            Assert.False(withdrawalMoneyPlusOneYear);


        }

        [Fact]
        public void Test_MaximumDepositOf15000()
        {
            InvestmentAccount account =
                new InvestmentAccount(2000, todaysDate);

            bool depositToMuch = account.TryMakeDeposit(15001);

            Assert.False(depositToMuch);


        }

        [Fact]
        public void Test_NoMoreDepositsIfMaxDepositIsReachedThatDay()
        {
            InvestmentAccount account =
                new InvestmentAccount(4000, todaysDate);

           bool depositMaximumAmount = account.TryMakeDeposit(15000);

           Assert.True(depositMaximumAmount);

           bool tryMakeSecondDepositAfterMaxAmount =
               account.TryMakeDeposit(1500);

           Assert.False(tryMakeSecondDepositAfterMaxAmount);
            

        }
    }
}
