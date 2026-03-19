# Stockly - Lagerhanterare

En modern, lättviktig lagerhanteringsapplikation byggd med **Blazor Web App** och **.NET 10.0**. Syftet med projektet är att bygga ett funktionellt verktyg för resurskontroll med fokus på snabbhet och tydlighet.

---

## 📋 Projektbeskrivning
Stockly är en generell lagerhanterare designad för verksamheter som hanterar stora volymer av identiska artiklar, såsom verktyg, byggvaror eller förbrukningsmaterial. Appen använder en **SQLite-databas** för persistent lagring och levereras med ett omfattande testsortiment på **100 artiklar** för att demonstrera systemets skalbarhet och prestanda.

## 🚀 Funktionalitet

### 📦 Produkthantering (CRUD)
- [ ] **Skapa:** Registrera nya produkter med namn, kategori, SKU, pris och saldo.
- [x] **Läsa:** En översiktlig tabellvy över hela lagret.
- [ ] **Uppdatera:** Justera priser, namn eller kategorier på befintliga varor.
- [ ] **Radera:** Ta bort utgångna eller felaktiga produkter från systemet.

### 🔢 Lagerlogik & Överblick
- [x] **KPI-Dashboard:** Visuella kort för snabb överblick av artiklar, lagervärde och varningar.
- [x] **Lagervärde:** Automatisk uträkning och valutaformatering av totalt ekonomiskt värde.
- [x] **Saldoändring:** Snabba knappar för att öka/minska antal direkt mot databasen.
- [x] **Nivåvarning:** Visuell indikator i tabell och dashboard när `Quantity <= MinStockLevel`.

### 🔍 Sök & Navigering
- [x] **Smart Sök:** Filtrera listan i realtid via SQL-frågor baserat på både **Produktnamn** och **SKU (Artikelnummer)**.
- [ ] **Kategorifilter:** Visa endast specifika varugrupper (t.ex. "Handverktyg").

## 🛠 Teknisk Stack
* **Ramverk:** .NET 10.0
* **UI:** Blazor Web App (Interactive Server Mode)
* **Databas:** **SQLite** via **Entity Framework Core**.
* **Styling:** Bootstrap 5 med anpassade utility-klasser.
* **Initial Data:** Automatisk populering (Seeding) av 100 realistiska testartiklar vid första uppstart.

## 💾 Datamodell (`Product.cs`)
Varje produktobjekt följer en strikt struktur för att säkerställa dataintegritet:
* `Guid Id` – Primärnyckel (Globalt unik identifierare).
* `string Name` – Beskrivande produktnamn.
* `string? Category` – Gruppering av produkter (t.ex. EL, VVS, BYGG).
* `string? SKU` – **Stock Keeping Unit** (Sökbart artikelnummer).
* `decimal Price` – Enhetspris (SEK).
* `int Quantity` – Aktuellt antal i lager.
* `int MinStockLevel` – Gräns för kritisk lagernivå.

---

## 🛠 Installation & Körning
1. Öppna lösningen i **Visual Studio 2022** (med .NET 10 SDK installerat).
2. Vid första körning skapas databasfilen `Stockly.db` automatiskt och populeras med testdata.
3. Tryck `F5` för att starta applikationen.
