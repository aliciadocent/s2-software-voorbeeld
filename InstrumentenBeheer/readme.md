# 🎼 InstrumentenBeheer – Voorbeeldproject S2 Software

Dit project is een voorbeeldimplementatie voor **Semester 2 – Software**.  
De applicatie is een simpele *Instrumenten Beheer / Instrumenten Inzicht App* waarmee instrumenten bekeken en beheerd kunnen worden. Het project ondersteunt de leeruitkomsten Analyse, Design, Development en Testing.

---

## 🎯 Doel van het project

Het doel van dit project is om studenten te laten oefenen met:

- het analyseren en documenteren van requirements  
- het ontwerpen van een domein- en klassendiagram  
- het bouwen van een **ASP.NET (MVC) webapplicatie** met een **layered architecture**  
- het gebruik van een relationele database  
- het schrijven van unit tests en acceptatietests  

Dit project hoort bij de repository:  
`https://github.com/aliciadocent/s2-software-voorbeeld`

---

## 🧩 Functionaliteit (globaal)

De InstrumentenBeheer-app ondersteunt onder andere:

- Een **overzicht van alle instrumenten**  
- Filteren op:
  - type instrument (bijv. fluit, trompet, gitaar, …)
  - status (beschikbaar, uitgeleend, in onderhoud)
- **Toevoegen** van nieuwe instrumenten
- (Optioneel/uitbreidbaar) **bewerken** en **verwijderen** van instrumenten

Deze functionaliteit is gekoppeld aan de requirements zoals beschreven in het analysedocument  
(bijv. `FR-01`, `FR-02`, bijbehorende businessregels en kwaliteitscriteria).

---

## 🏗️ Architectuur

De applicatie is opgezet volgens een **layered architecture**:

- **Presentation layer (MVC)**  
  - ASP.NET MVC (controllers, views, viewmodels)  
  - Niet uitgewerkt in het klassendiagram, maar wel aanwezig in de webapp

- **Logic layer**  
  - Domeinlogica rond `Instrument` en `InstrumentContainer`
  - Toepassing van businessregels en validatie

- **Interface layer**  
  - Interfaces zoals `IInstrumentContainer` en `IInstrumentDAL`
  - Zorgt voor losse koppeling tussen Logic en Data

- **Data layer**  
  - Implementaties van `InstrumentDAL`
  - Werkt met `InstrumentDTO` en een relationele database

De layered architecture is gebaseerd op de uitleg uit de FHICT-module *Layered Architecture*.

---

## 📂 Projectstructuur (globaal)

De exacte namen kunnen iets afwijken, maar grofweg ziet de structuur er zo uit:

```text
InstrumentenBeheer/
  ├── InstrumentenBeheer.Web/        # ASP.NET (MVC) webapp
  ├── InstrumentenBeheerLogic/       # Domeinlogica (Instrument, InstrumentContainer, enums)
  ├── InstrumentenBeheerInterface/   # Interfaces + DTO-definities
  ├── InstrumentenBeheerDAL/         # Data access layer
  ├── InstrumentenBeheerDAL.Stub/    # Stub/fake DAL voor testen
  ├── InstrumentenBeheer.Tests/      # Unit tests (bv. voor GetAllInstruments)
  └── README.md                      # Dit bestand