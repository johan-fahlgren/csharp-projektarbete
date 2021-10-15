# RAPPORT [PROJEKTARBETE](https://github.com/ECU-JF/csharp-projektarbete)

    Vi valde scenario #1 eftersom det fanns mycket likheter med tidigare �vningar och tillf�llig avsaknad av fantasi n�r vi skulle p�b�rja uppgiften.

 <br />


# Planering

Planeringen har g�tt bra mellan oss. Vi har i stort s�tt suttit varje lektionsfri dag och parprogrammerat. 
Under sj�lva sessionen har vi bytt vem som kodat var efter vi l�st ett issue tillsammans.
Efter varje session har vi best�mt en tid och dag vi ska sitta och jobba igen.
Jag har f�tt lov att flytta fram v�ra tider n�gon g�ng pga. allt som h�nder privat.

Vi satt tillsammans och skapade [issues](https://github.com/ECU-JF/csharp-projektarbete/issues) och la in 
dem i v�r [Kanban](https://github.com/ECU-JF/csharp-projektarbete/projects/1) vilket var en bra tid att 
diskutera kring uppgiften. 

Om vi skulle g�ra n�got b�ttre s� �r det nog att s�tta ett larm eller liknande s� vi kommer ih�g att ta 
lite rast samt lunch i tid.

 <br />

---
## Implementering

Vi b�rjade med att g�ra enkla test och l�sningar f�r att jobba oss igenom punkterna i v�ra issues, 
vilket rullade p� bra och ganska enkelt. 

Vi fastnade till slut p� `Test_TryWithdrawalFiveTimesThenAddFee_SavingsAccount`. Vi kom inte p� 
n�gon l�sning f�r v�r Logic vilket resulterade i att vi l�ste den genom ett test. Detta blir tyv�rr ett
"dumt test" som egentligen inte testar n�gon faktisk kod, men det blev l�sningen pga. att vi saknade 
kunskapen f�r att l�sa den. Pratade med en kompis som tipsade om att anv�nda `dictionary` f�r att h�lla 
reda p� ins�ttning kopplat till ett �r, men hade aldrig andv�nt `dictionary` och tiden k�ndes f�r knapp.
Det �r dock n�got jag g�rna kommer tillbaka till och testar senare.

```
[Fact]
        public void Test_TryWithdrawalFiveTimesThenAddFee_SavingsAccount()
        {
            SavingsAccount account = 
                new SavingsAccount(5000);
            
            int amount = 500;

            for (int trys = 1; trys <= 6; trys++)
            {
                // Try 5 withdrawals
                if (trys <= 5)
                {
                    account.TryMakeWithdrawal(amount);
                }
                // Add 1% fee after 5 withdrawals
                else
                {
                    int fee = (amount/100) + amount;
                    
                    account.TryMakeWithdrawal(fee);
                    
                    Assert.Equal(1995, account.AccountBalance());
                }
            }
        }
```

 <br />

Efter lektionen d�r vi l�rde oss om *Arv* med `basklasser` och `subklasser` best�mde vi oss f�r 
att g�ra en refactor och anv�nda oss av arv. Vi skrev om v�r kod och implementerade arv vilket 
k�ndes som en nyttig och bra �vning efter lektionen.     

Hade g�rna f�tt ner m�ngden kod och antal test , exempelvis genom `[Theory]` som vi presic l�rt oss 
eller genom vad Joakim l�rde mig idag att:
```
bool depositMoney = 
                account.TryMakeDeposit(15000);

            Assert.True(depositMoney);
 ```       
Kan lika g�rna skrivas som:

```
Assert.True(account.TryMakeDeposit(15000));

```

 <br />

---
## Utverdering

�r n�jd �ver att vi lyckades implementera enligt Arv metoden. K�ndes lite l�skigt att skriva
om s� stora delar av koden, men v�ldigt givande n�r alla test fortfarande fungerade.

Vi �r p� lite olika niv�er i v�r kodning just nu men det gjorde att jag kunde "rubberducka" 
ganska mycket vilket jag tror var nyttigt f�r oss b�da.  

<br />

    Johan Fahlgren, 2021-10-15