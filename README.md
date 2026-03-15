# Stockly - Lagerhanterare

En modern, lättviktig lagerhanteringsapplikation byggd med **Blazor Web App** och **.NET 10.0**. Syftet med projektet är att bygga ett funktionellt verktyg för resurskontroll med fokus på snabbhet och tydlighet.

---

## 📋 Projektbeskrivning
Stockly är en generell lagerhanterare designad för verksamheter som hanterar stora volymer av identiska artiklar, såsom verktyg, byggvaror eller förbrukningsmaterial. Appen hjälper användaren att hålla koll på lagersaldon och prissättning med automatiska varningar när artiklar behöver beställas hem.

## 🚀 Funktionella krav

### 📦 Produkthantering (CRUD)
- [ ] **Skapa:** Registrera nya produkter med namn, kategori, SKU, pris och saldo.
- [x] **Läsa:** En översiktlig tabellvy över hela lagret.
- [ ] **Uppdatera:** Justera priser, namn eller kategorier på befintliga varor.
- [ ] **Radera:** Ta bort utgångna eller felaktiga produkter från systemet.

### 🔢 Lagerlogik & Överblick
- [x] **KPI-Dashboard:** Visuella kort för snabb överblick av artiklar, lagervärde och varningar.
- [x] **Lagervärde:** Automatisk uträkning och valutaformatering av totalt ekonomiskt värde.
- [ ] **Saldoändring:** Snabba knappar för att öka/minska antal (In- och utleverans).
- [ ] **Nivåvarning:** Visuell indikator i tabell när `Quantity <= MinStockLevel`.

### 🔍 Sök & Navigering
- [ ] **Smart Sök:** Filtrera listan i realtid baserat på både **Produktnamn** och **SKU (Artikelnummer)**.
- [ ] **Kategorifilter:** Visa endast specifika varugrupper (t.ex. "Handverktyg").

## 🛠 Teknisk Stack
* **Ramverk:** .NET 10.0
* **UI:** Blazor Web App (Interactive Server Mode)
* **Styling:** Bootstrap 5 med anpassade utility-klasser.
* **Data:** Skiktad arkitektur med `ProductService` och en dedikerad `DataProvider` för testdata.

## 💾 Datamodell (`Product.cs`)
Varje produktobjekt följer en strikt struktur för att säkerställa dataintegritet:
* `Guid Id` – Globalt unik teknisk identifierare.
* `string Name` – Beskrivande produktnamn.
* `string? Category` – Gruppering av produkter.
* `string? SKU` – **Stock Keeping Unit** (Mänskligt läsbart artikelnummer).
* `decimal Price` – Enhetspris (SEK).
* `int Quantity` – Aktuellt antal i lager.
* `int MinStockLevel` – Gräns för när lagret anses vara kritiskt lågt.
* `DateTime LastUpdated` – Tidstämpel som uppdateras automatiskt vid varje ändring.

---

## 🛠 Installation & Körning
1. Öppna lösningen i **Visual Studio 2022** (med .NET 10 SDK installerat).
2. Godkänn SSL-certifikatet för HTTPS vid första körning.
3. Tryck `F5` för att starta applikationen.
