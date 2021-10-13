using System;
using System.Collections.Generic;
using Logic;
using Xunit;

namespace Tests
{
    public class AccountTests
    {
        //FIELDS
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
        // TEST SALARY ACCOUNT
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

        // TEST CREDIT ACCOUNT
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
                new InvestmentAccount(500);

            bool depositMoney = account.TryMakeDeposit(5000);

            Assert.True(depositMoney);
        }

        [Fact]
        public void Test_WithdrawalMoneyInvestmentAccount()
        {
            InvestmentAccount account = 
                new InvestmentAccount(5500);

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
                new InvestmentAccount(5000);

            // First withdrawal within a year
            bool withdrawalMoneyToday = 
                account.TryMakeWithdrawal(1000);

            Assert.True(withdrawalMoneyToday);

            // Second withdrawal within a year
            account.CurrentDate = DateTime.Today + TimeSpan.FromDays(250);
           
            bool withdrawalMoneySameYear = 
                account.TryMakeWithdrawal(2000);

            Assert.False(withdrawalMoneySameYear);
            
            // Withdrawal plus one year from now
            account.CurrentDate = DateTime.Today + TimeSpan.FromDays(369);

            bool withdrawalMoneyPlusOneYear =
                account.TryMakeWithdrawal(1000);

            Assert.True(withdrawalMoneyPlusOneYear);
            
        }

        [Fact]
        public void Test_MaximumCashDepositOf15000()
        {
            InvestmentAccount account =
                new InvestmentAccount(2000);

            bool depositToMuch = account.TryMakeCashDeposit(15001);

            Assert.False(depositToMuch);
            
        }

        [Fact]
        public void Test_NoMoreDepositsIfMaxDepositIsReachedThatDay()
        {
            InvestmentAccount account =
                new InvestmentAccount(4000);
            
            // Max kontantinsättning
           bool depositMaximumAmount = account.TryMakeCashDeposit(15000);

           Assert.True(depositMaximumAmount);

           // Försök kontantinsättning samma dag
           bool tryMakeSecondDepositAfterMaxAmount =
               account.TryMakeCashDeposit(1500);

           Assert.False(tryMakeSecondDepositAfterMaxAmount);

           // Försök kontantinsättning dagen efter

           account.CurrentDate = DateTime.Today + TimeSpan.FromDays(1);

           bool tryMakeDepositOneDayLater = account.TryMakeCashDeposit(3000);

           Assert.True(tryMakeDepositOneDayLater);


        }
    }
}
