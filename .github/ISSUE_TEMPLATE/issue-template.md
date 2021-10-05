---
name: Issue template
about: Issue template with examples
title: "[ADD]"
labels: new feature
assignees: ''

---

**Vad ska programmet kunna göra**

> Man ska kunna sätta in pengar på ett allkonto,
> men inte för mycket på en gång om man sätter in kontanter.

**Skriv en todo lista för att lösa problemet**

> - [ ] Testa skapande av konto
> - [ ] Testa insättning av kontanter
> - [ ] Testa att insättningar av kontanter högre än 12500 SEK inte är tillåtet vid ett tillfälle
> - [ ] Testa att totala insättningar under ett dygn inte får överstiga 12500 SEK

**API förslag**

> Börja med en `Account` klass som har en metod `InsertCash`. Använd en ITime interface för att testa vad som händer inom 24h
