# RAPPORT [PROJEKTARBETE](https://github.com/ECU-JF/csharp-projektarbete)

    Vi valde scenario #1 eftersom det fanns mycket likheter med tidigare övningar och tillfällig avsaknad av fantasi när vi skulle påbörja uppgiften.

 <br />


# Planering

Planeringen har gått bra mellan oss. Vi har i stort sätt suttit varje lektionsfri dag och parprogrammerat. 
Under själva sessionen har vi bytt vem som kodat var efter vi löst ett issue tillsammans.
Efter varje session har vi bestämt en tid och dag vi ska sitta och jobba igen.
Jag har fått lov att flytta fram våra tider någon gång pga. allt som händer privat.

Vi satt tillsammans och skapade [issues](https://github.com/ECU-JF/csharp-projektarbete/issues) och la in 
dem i vår [Kanban](https://github.com/ECU-JF/csharp-projektarbete/projects/1) vilket var en bra tid att 
diskutera kring uppgiften. 

Om vi skulle göra något bättre så är det nog att sätta ett larm eller liknande så vi kommer ihåg att ta 
lite rast samt lunch i tid.

 <br />

---
## Implementering

Vi började med att göra enkla test och lösningar för att jobba oss igenom punkterna i våra issues, 
vilket rullade på bra och ganska enkelt. 

Vi fastnade till slut på `Test_TryWithdrawalFiveTimesThenAddFee_SavingsAccount`. Vi kom inte på 
någon lösning för vår Logic vilket resulterade i att vi löste den genom ett test. Detta blir tyvärr ett
"dumt test" som egentligen inte testar någon faktisk kod, men det blev lösningen pga. att vi saknade 
kunskapen för att lösa den. Pratade med en kompis som tipsade om att använda `dictionary` för att hålla 
reda på insättning kopplat till ett år, men hade aldrig andvänt `dictionary` och tiden kändes för knapp.
Det är dock något jag gärna kommer tillbaka till och testar senare.

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

Efter lektionen där vi lärde oss om *Arv* med `basklasser` och `subklasser` bestämde vi oss för 
att göra en refactor och använda oss av arv. Vi skrev om vår kod och implementerade arv vilket 
kändes som en nyttig och bra övning efter lektionen.     

Hade gärna fått ner mängden kod och antal test , exempelvis genom `[Theory]` som vi presic lärt oss 
eller genom vad Joakim lärde mig idag att:
```
bool depositMoney = 
                account.TryMakeDeposit(15000);

            Assert.True(depositMoney);
 ```       
Kan lika gärna skrivas som:

```
Assert.True(account.TryMakeDeposit(15000));

```

 <br />

---
## Utverdering

Är nöjd över att vi lyckades implementera enligt Arv metoden. Kändes lite läskigt att skriva
om så stora delar av koden, men väldigt givande när alla test fortfarande fungerade.

Vi är på lite olika nivåer i vår kodning just nu men det gjorde att jag kunde "rubberducka" 
ganska mycket vilket jag tror var nyttigt för oss båda.  

<br />

    Johan Fahlgren, 2021-10-15