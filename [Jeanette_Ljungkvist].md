# Projektrapport

<br />

## [Scenario #1 - Bankkonton](https://github.com/ECU-JF/csharp-projektarbete#scenario-1---bankkonton)


<br />

### Planering

***Hur gick planeringen? Varför? Vad kan göras bättre?***

Jag tycker att planeringen har gått bra. Vi började med att diskutera om hur vi 
skulle bygga upp vårat program och skapade sedan **Issues** som vi lade i vårt 
[**Kanban**](https://github.com/ECU-JF/csharp-projektarbete/projects/1) projekt. 
Vi började med 5 st issues och lade senare till en till issue efter att vi hade haft
lektionen om **Arv** och tyckte att vi kunde försöka oss på en refactor av våran kod.
Vi bestämde oss sedan för att par programmera vårt projekt och bestämde tid för att mötas
på discord.

Det som kunde göras bättre är att vi kanske skulle haft vår kommunikation via sms i stället
för att endast använda oss av discord då discord inte är alltför pålitlig med att skicka
notifikationer så det är lätt att missa om någon har skrivit till en på den plattformen.
Det hände vid ett par tillfällen att vi inte såg att den andre hade skrivit ett meddelande
 förrän flera timmar senare.

<br />

### Implementering

***Hur gick implementeringen? Motivera lösningar/beslut. Vad kan göras bättre?***

Vi satt via discord och skrev programmet tillsammans med att skärmdela samtidigt som vi
diskuterade hur vi skulle koda.

Jag tycker att vi fick gjort det vi hade bestämt oss för att göra. Det som vi ändrade på
som vi från början inte hade planerat att göra var att vi försökte oss på att skriva om 
våran kod med arv efter att vi gått igenom det på lektionen.

Det enda vi hade lite problem med var att förstå hur vi skulle få till våra sista tester som
använde sig av **DateTime**. Johan tog hjälp av en kompis som hjälpte honom med hur vi skulle
tänka och Johan satt sedan och förklarade för mig hur vi skulle göra medan jag kodade. 

Det uppdagades även att ett av våra tester `Test_TryWithdrawalFiveTimesThenAddFee_SavingsAccount()` 
inte fungerade som vi ville att det skulle göra och att det troligtvis skulle kräva att vi
lade till en **Dictionary** för att lösa det problemet. Tyvärr så kände varken jag eller Johan
att vi hade tillräckligt med kunskaper för att få till en sådan lösning.

Det jag tror vi skulle kunna göra lite bättre är att vi eventuellt skulle kunna städa upp våra
tester lite grann med att till exempel implementera **[Theory]** i några av dom.

<br />

### Utvärdering

***Vad blev du mest nöjd med och varför?***

Jag blev positivt överraskad över att det var lättare att skriva om koden med **Arv** än vad
jag trodde det skulle vara. Var väldigt rädd att vi skulle lyckas förstöra programmet när vi
började flytta runt i koden. Är även glad över att vi fick hjälp med att få till tänket runt
**DateTime** då vi hade kört fast rätt rejält på den biten.

Johan är lite säkrare på kodning än vad jag är så han har fått hjälpa mig och förklara en hel
del vilket har hjälpt mig mycket med att förstå hur jag ska tänka när jag kodar.

<br />

Jeanette Ljungkvist 15/10-2021