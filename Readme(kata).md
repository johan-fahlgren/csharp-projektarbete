# ankapp

I denna online [Bank](https://en.wikipedia.org/wiki/Bank) kan du enkelt skapa olika konton f�r din behov.

> **Kontotyper som erbjuds:**  
> - Sparkonto
> - Kreditkonto
> - Investringssparkonto
> - L�nekonto
    



## **Features**

**Sparkonto**  
   * [x] M�jlighet till fem uttag per �r sedan en avgift p� 1% per uttag.
   * [x] Max ins�ttning av 15.000 kr i kontanter per dag. 

**Investeringskonto**
  * [x] Max ett uttag per �r.

**Kreditkonto**
  * [x] Ha en kredit p� 20.000 kr

**L�nekonto**
  * [x] Uttag av kontanter f�r ej �verskrida saldo.

**Allm�nna kontoregler**
  * [x] Man f�r ej s�tta ut minusv�rde.
  
  
  **Framtida features**
- [ ]  Max kontoins�ttning p� 15.000 kr varje dag.
- [ ] �rlig kontoavgift p� 500 kr.



## **Tests**

Testerna genomf�rs enlig TDD metoden med hj�lp av xUnit.net framework. 
  
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

Testdriven utveckling (engelska: test-driven development, TDD) �r en systemutvecklingsmetod som s�tter starkt fokus p� automatiserad enhetstestning av varje programblock, f�ljt av integrationstester och anv�ndartester.

Metoden f�respr�kar att ingen programkod f�r inf�ras eller �ndras utan att testfall har skrivits f�rst. Innan kod checkas in ska utvecklaren lokalt k�ra igenom de nya testfallen f�r den senaste kod�ndringen, samt alla testfall. F�rst n�r testfallen har exekverats och f�tt godk�nt �r utvecklaren till�ten att checka in kod�ndringen.

Tack vare TDD t�rs utvecklaren g�ra �ven genomgripande f�r�ndringar av koden och genom en bred testsvit f�r man veta om den egna kod�ndringen haft s�nder annan kod i systemet.


![T D D Graphic](Assets\Pictures\TDD_Graphic.jpg)

#### **xUnit**

�r en gratis, open-source unit test verktyg f�r .NET framework. 