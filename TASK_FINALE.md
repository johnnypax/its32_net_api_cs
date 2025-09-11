# Creare un sistema di gestione Cinema.

### Tecnologie Richieste

- **Back-End**: C# con MinimalAPI
- **Front-End**: HTML, CSS, JavaScript
- **Ambiente di sviluppo**: Visual Studio Code con estensione Live Server

### Obiettivo del Progetto

Realizzare un'applicazione web per la gestione delle risorse di un cinema, con funzionalità complete per la visualizzazione delle proiezioni e l'acquisto dei biglietti.

### Risorse da Gestire

#### 1. Proiezione (Obbligatoria)

Ogni proiezione deve includere:

- Titolo del film
- Durata
- Genere (singolo)
- Nazionalità
- Lingua
- Descrizione
- Sala
- Orario di inizio

#### 2. Biglietto

Ogni biglietto deve includere:

- Codice univoco (UUID)
- Orario d'acquisto
- Posto assegnato (fila e numero)
- Costo

### Funzionalità del Front-End

- Tabella con tutte le proiezioni disponibili
- Tabella con tutti i biglietti acquistati e le relative proiezioni
- Possibilità di inserire una proiezione
- Possibilità di cancellare una prenotazione
- Possibilità di aggiornare i dettagli di una proiezione (HARD)
- Possibilità di acquistare un biglietto (generare automaticamente una prenotazione) al click di un pulsante sulla tabella con proiezione.

### Suggerimenti Extra (facoltativi ma utili)

Se vuoi rendere il progetto ancora più interessante:

- Filtro per genere, lingua o orario nella tabella delle proiezioni
- Generazione di una ricevuta dopo l'acquisto del biglietto
- Visualizzazione calendario delle proiezioni
- Validazione del posto disponibile prima dell'acquisto