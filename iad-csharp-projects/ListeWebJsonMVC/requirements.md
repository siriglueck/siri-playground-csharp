# Projektanforderungen

## Übersicht
Diese Webanwendung ist eine Verwaltungsplattform für Termine, Aufgaben und Kategorien.

## Funktionale Anforderungen

### 1. Terminliste
Die Anwendung muss eine Seite zur Verwaltung von Terminen bereitstellen mit folgenden Feldern:
- **Titel**: Bezeichnung des Termins
- **Starttermin**: Datum und Uhrzeit des Termins
- **Dauer**: Dauer in Minuten
- **Ort**: Veranstaltungsort
- **Kontaktperson**: Ansprechpartner für den Termin
- **Beschreibung**: Detaillierte Beschreibung des Termins
- **Kategorien**: Zuordnung zu einer oder mehreren Kategorien (z.B. Familie, Beruf, Hobby)

### 2. Aufgabenliste
Die Anwendung muss eine Seite zur Verwaltung von Aufgaben bereitstellen mit folgenden Feldern:
- **Titel**: Bezeichnung der Aufgabe
- **Beschreibung**: Detaillierte Beschreibung der Aufgabe
- **Zu erledigen von**: Startdatum für die Aufgabe
- **Zu erledigen bis**: Fälligkeitsdatum für die Aufgabe
- **Kategorie**: Zuordnung zu einer Kategorie

### 3. Kategorieliste
Die Anwendung muss eine Seite zur Verwaltung von Kategorien bereitstellen mit folgenden Feldern:
- **Titel**: Name der Kategorie
- **Beschreibung**: Beschreibung der Kategorie
- **Farbkennzeichnung**: Farbe zur visuellen Markierung von Terminen und Aufgaben

## CRUD-Operationen
Für alle drei Bereiche (Termine, Aufgaben, Kategorien) müssen folgende Operationen möglich sein:
- **Erstellen**: Neue Einträge hinzufügen
- **Bearbeiten**: Bestehende Einträge ändern
- **Löschen**: Einträge entfernen

## Datenspeicherung
- Alle Daten werden in separaten JSON-Dateien gespeichert:
  - `termine.json` für Termine
  - `aufgaben.json` für Aufgaben
  - `kategorien.json` für Kategorien
- Die Dateien werden im Dateisystem der Anwendung gespeichert

## Technische Anforderungen
- **Framework**: ASP.NET Core MVC
- **Programmiersprache**: C#
- **Dateiformat**: JSON für Datenpersistenz

## Benutzeroberfläche
- Responsive Design
- Übersichtliche Navigation zwischen den drei Hauptseiten
- Formulare für Erstellen und Bearbeiten
- Bestätigungsdialoge beim Löschen
- Farbliche Kennzeichnung von Einträgen basierend auf Kategorien (optioal)