> Efter genomförd kurs ska den studerande ha kompetens för att:
>
> 10. Skapa och analysera program lösningar i C#
> 11. Producera kod enligt TDD (Test-Driven Development)

# Projektuppgift

## Övergripande

Detta är det första projektet där ni kodar tillsammans, så fokus kommer att ligga på
fungerande sammarbete och att använda branching, PR och Kanban brädet inne på GitHub.

Ni kommer att jobba enligt TDD utefter ett scenario men ni måste inte bli klara med
uppgiften. I framtida kurser när ni kan arbetsflödet så kommer det att bli mer fokus
på färdiga produkter

### G krav (grupparbete)

- ca 10 eller fler commits per person
- Koda enligt TDD (Red/Green/Refactor samt Spike)

### G krav (individuel rapport)

- Skriv ner rapporten i en markdownfil `[ditt namn].md` i projektet
- Använd rubriker, underrubriker och styckesindelning
- Reflektera över och analysera projektet
  - Hur gick planeringen? Varför? Vad kan göras bättre?
  - Hur gick implementeringen? Motivera lösningar/beslut. Vad kan göras bättre?
  - Vad blev du mest nöjd med och varför?

### Inlämning (per person)

- Lämna in en zip av projektet till "Projektuppgift" inne på PingPong och länka till repon
- Lämna in en zip av projektet till "Projektrapport" inne på PingPong och länka till rapporten inne i repon

### Deadlines

**Deadline #1** - 15/10  
**Deadline #2** - 29/10

## Scenario #1 - Bankkonton

En nytt bankföretag, iBank, som bara finns online ska starta upp och
de behöver utveckla en backend som sköter kontohanteringen på ett säkert sätt.

Det finns olika sorts bankkonto

1. Sparkonto som tillåter max 5 uttag om året (fler kan göras men då kostar det 1% av uttaget)
2. Lönekonto som tillåter obegränsat antal uttag
3. Kreditkonto som tillåter kredit över en viss gräns
4. Investeringskonto som tillåter ett uttag om året

Vilka regler gäller för bankkonton rent allmänt?

- Man får inte ta ut mer pengar än vad som finns i kontot
- Om kredit finns får man inte ta ut mer än krediten
- Man får inte sätta ut minusvärden ( alltså sätta in -100:- )
- Bankens egna avgifter tas ut även om kontot är på minus
- Cash Insättningar på Max 15000 åt gången (annars kan man börja misstänka att det är pengatvätt), inga fler insättningar tillåts den dagen.

Tolka om kraven till en serie tester som ni sen börjar implementera enligt TDD.

## Scenario #2 - Eget scenario

Kom på ett eget scenario och dokumentera det i en `readme.md`.
Använd sedan ert scenario för att formulera egna issues och tester.
 Save
