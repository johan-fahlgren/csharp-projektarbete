# ankapp

I denna online [Bank](https://en.wikipedia.org/wiki/Bank) kan du enkelt skapa olika konton för din behov.

> **Kontotyper som erbjuds:**  
> - Sparkonto
> - Kreditkonto
> - Investringssparkonto
> - Lönekonto
    



## **Features**

**Sparkonto**  
   * [x] Möjlighet till fem uttag per år sedan en avgift på 1% per uttag.
   * [x] Max insättning av 15.000 kr i kontanter per dag. 

**Investeringskonto**
  * [x] Max ett uttag per år.

**Kreditkonto**
  * [x] Ha en kredit på 20.000 kr

**Lönekonto**
  * [x] Uttag av kontanter får ej överskrida saldo.

**Allmänna kontoregler**
  * [x] Man får ej sätta ut minusvärde.
  
  
  **Framtida features**
- [ ]  Max kontoinsättning på 15.000 kr varje dag.
- [ ] Årlig kontoavgift på 500 kr.



## **Tests**

Testerna genomförs enlig TDD metoden med hjälp av xUnit.net framework. 
  
*exempel test:*  

```
[Fact]
        public void Test_MakeWithdrawal()
        {
            // Creating new Savings account with 1000 in balance
            SavingsAccount account = new SavingsAccount(1000);

            // Withdrawal with money left
            var withdrawalMoney = account.TryMakeWithdrawal(250);
            
            // Testing if withdrawal was possible (true, within account balance)
            Assert.True(withdrawalMoney);

            // Overdraft withdrawal
            withdrawalMoney = account.TryMakeWithdrawal(800);
            
            // Testing if withdrawal was possible (false, due to overdraft)
            Assert.False(withdrawalMoney);
        }
```

#### **TDD**

Testdriven utveckling (engelska: test-driven development, TDD) är en systemutvecklingsmetod som sätter starkt fokus på automatiserad enhetstestning av varje programblock, följt av integrationstester och användartester.

Metoden förespråkar att ingen programkod får införas eller ändras utan att testfall har skrivits först. Innan kod checkas in ska utvecklaren lokalt köra igenom de nya testfallen för den senaste kodändringen, samt alla testfall. Först när testfallen har exekverats och fått godkänt är utvecklaren tillåten att checka in kodändringen.

Tack vare TDD törs utvecklaren göra även genomgripande förändringar av koden och genom en bred testsvit får man veta om den egna kodändringen haft sönder annan kod i systemet.


![T D D Graphic](Assets\Pictures\TDD_Graphic.jpg)

#### **xUnit**

Är en gratis, open-source unit test verktyg för .NET framework. 