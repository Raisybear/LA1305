# Projekt-Dokumentation

Elias Spycher und Robin Sacher

| Datum      | Version | Zusammenfassung                                                                                                                                |
| ---------- | ------- | ---------------------------------------------------------------------------------------------------------------------------------------------- |
| 10.05.2024 | 0.0.1   | Projektdokumentation erstellt und Phasen I und P von IPERKA abgeschlossen                                                                      |
| 17.05.2024 | 0.0.2   | Projektdokumentation weiter bearbeitet, Testfällle erstellt und Main Menu + Level Auswahl in Game hinzugefügt, Level 1 teilweise implementiert |
| 24.05.2024 | 0.0.3   | Projekt weiter verbessert. Audio hinzugefügt. Death-Counter implementiert. Asset hinzugefügt. Level Design verbessert + Level 2 hinzugefügt    |
| 31.05.2024 | 0.0.4   | Projekt weiter verbessert. Animationen hinzugefügt, Levelauswahl aktualisiert, an den Levels weitergebaut.                                     |
| 07.06.2024 | 0.0.5   | Projekt weiter verbessert. An den Levels weitergebaut.                                                                                         |
| 14.06.2024 | 1.0.0   | Projekt weiter verbessert. Finish hinzugefügt, Levels fertig gebaut, Assets geändert. Projektdokumentation und Mahara Beitrag geschrieben      |

## 1 Informieren

### 1.1 Ihr Projekt

Wir haben uns entschieden ein Unity Game zu programmieren und Realisieren, Als Grundidee und Inspiration haben wir das Jump n Run Game Geometry Dash genommen und eine eigene Version davon in Unity umgesetzt.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ        | Beschreibung                                                                                                         |
| ---- | --------------- | ---------- | -------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktional | Als ein Spieler möchte ich einfache Steuerung haben (Springen), damit das Spiel leicht zu bedienen ist.              |
| 2    | Muss            | Qualität   | Als ein Spieler möchte ich flüssige Animationen, damit das Spielgefühl ansprechend ist.                              |
| 3    | Kann            | Funktional | Als ein Spieler möchte ich verschiedene Levels auswählen können, damit das Spiel für alle Spielstärken geeignet ist. |
| 4    | Muss            | Funktional | Als ein Spieler möchte ich Feedback bei Fehlern, damit ich aus meinen Fehlern lernen kann.                           |
| 5    | Muss            | Qualität   | Als ein Spieler möchte ich eine ansprechende Soundkulisse, damit das Spielerlebnis immersiv ist.                     |
| 6    | Kann            | Qualität   | Als ein Spieler möchte ich eine ansprechende Benutzeroberfläche, damit ich das Spiel leicht navigieren kann.         |
| 7    | Muss            | Qualität   | Als ein Spieler möchte ich eine reaktionsfähige Steuerung, damit die Eingabe präzise ist.                            |
| 8    | Muss            | Funktional | Als ein Entwickler möchte ich eine klare Code-Dokumentation, damit die Wartung und Erweiterung erleichtert wird.     |
| 9    | Muss            | Funktional | Als ein Spieler möchte ich einfache Level-Starts, damit ich einen einfachen Start in das Spiel habe.                 |
| 10   | Muss            | Funktional | Als ein Spieler möchte ich klare und verständliche Spielregeln, damit ich sofort weiß, wie das Spiel funktioniert.   |
| 11   | Kann            | Qualität   | Als ein Spieler möchte ich, dass jedes Level ein einzigartiges Design hat, um visuelle Abwechslung zu bieten.        |
| 12   | Kann            | Qualität   | Als ein Spieler möchte ich verschiedene Musiktracks je nach Level, um die Atmosphäre zu verbessern.                  |
| 13   | Kann            | Funktional | Als ein Spieler möchte ich eine Pause-Funktion, um das Spiel jederzeit unterbrechen zu können.                       |
| 14   | Kann            | Funktional | Als ein Spieler möchte ich einen Death-Counter, um zu sehen, wie oft ich gestorben.                                  |

### 1.3 Testfälle

| TC-№ | Ausgangslage                          | Eingabe                     | Erwartete Ausgabe                                                                   |
| ---- | ------------------------------------- | --------------------------- | ----------------------------------------------------------------------------------- |
| 1.1  | Spiel gestartet                       | Drücken vom Leertaste       | Der Spieler springt                                                                 |
| 2.1  | Spiel gestartet                       | Drücken von Leertaste       | Die Sprunganimation ist flüssig                                                     |
| 3.1  | Spiel nicht gestartet                 | Mausklick auf Spiel starten | Das Menu mit verschiedenen Level öffnet sich                                        |
| 4.1  | Spiel gestartet                       | In Hinderniss rennen        | Ausgabe im Spiel von "Ein Hinderniss war im weg"                                    |
| 5.1  | Spiel gestartet                       | Level ausgewählt            | Start des Soundtracks                                                               |
| 6.1  | Spiel nicht gestartet                 | Mausklick auf Spiel starten | Das Startmenu öffnet sich und ist übersichtlich                                     |
| 7.1  | Spiel gestartet                       | Drücken von Leertaste       | Die Sprunganimation wird ohne Verzögerung ausgefürt                                 |
| 8.1  | Code geöffnet                         | Code Lesen                  | Der Code ist übersichtlich und gut kommentiert                                      |
| 9.1  | Spiel gestartet, ein Level ausgewäht  | Ausweichen der Hindernisse  | Der Anfang des Levels ist einfach und wird immer schwieriger                        |
| 10.1 | Spiel nicht gestartet                 | Mausklick auf Spiel starten | Die Spielregeln werden im Menu angezeigt                                            |
| 11.1 | Spiel gestartet                       | Level Nr. 1 auswählen       | Das Level sieht einzigartig aus                                                     |
| 11.2 | Spiel gestartet                       | Level Nr. 2 auswählen       | Das Level sieht anders als Level Nr. 1 aus                                          |
| 11.3 | Spiel gestartet                       | Level Nr. 3 auswählen       | Das Level sieht anders als Level Nr. 1 und Nr. 2 aus                                |
| 12.1 | Spiel gestartet                       | Level Nr. 1 auswählen       | Soundtrack startet                                                                  |
| 12.2 | Spiel gestartet                       | Level Nr. 2 auswählen       | Neuer Soundtrack, wlecher sich von Soundtrack Nr. 1 unterscheidet, startet          |
| 12.3 | Spiel gestartet                       | Level Nr. 3 auswählen       | Neuer Soundtrack, wlecher sich von Soundtrack Nr. 1 und Nr. 2unterscheidet, startet |
| 13.1 | Spiel gestartet, ein Level ausgewählt | ESC-Taste drücken           | Das Spiel wird pausiert                                                             |
| 14.1 | Spiel gestartet, ein Level ausgewählt | Durch Hinderniss sterben    | Death-Counter wird um 1 erhöht                                                      |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

Wir haben keine Diagramme

## 2 Planen

| AP-№ | Frist      | Zuständig                    | Beschreibung        | geplante Zeit |
| ---- | ---------- | ---------------------------- | ------------------- | ------------- |
| 1.A  | 14.06.2024 | Elias Spycher                | Sprung Funktion     | 60'           |
| 2.A  | 14.06.2024 | Elias Spycher                | Sprung Animation    | 10'           |
| 3.A  | 14.06.2024 | Robin Sacher                 | Level Auswahl       | 20'           |
| 4.A  | 14.06.2024 | Robin Sacher                 | Feedback            | 20'           |
| 5.A  | 14.06.2024 | Elias Spycher                | Musik im Game       | 60'           |
| 6.A  | 14.06.2024 | Robin Sacher                 | Menu                | 90'           |
| 7.A  | 14.06.2024 | Elias Spycher                | Sprung Animation    | 10'           |
| 8.A  | 14.06.2024 | Elias Spycher / Robin Sacher | Clean Code          | 60'           |
| 9.A  | 14.06.2024 | Robin Sacher / Elias Spycher | Einfacher Start     | 60'           |
| 10.A | 14.06.2024 | Robin Sacher                 | Spielregeln im Menu | 20'           |
| 11.A | 14.06.2024 | Elias Spycher/Robin Sacher   | Level 1 Design      | 120'          |
| 11.B | 14.06.2024 | Robin Sacher                 | Level 2 Design      | 120'          |
| 11.C | 14.06.2024 | Elias Spycher                | Level 3 Design      | 120'          |
| 12.A | 14.06.2024 | Elias Spycher                | Level 1 Musik       | 30'           |
| 12.B | 14.06.2024 | Elias Spycher                | Level 2 Musik       | 30'           |
| 12.C | 14.06.2024 | Elias Spycher                | Level 3 Musik       | 30'           |
| 13.A | 14.06.2024 | Robin Sacher                 | Escape -> Menu      | 40'           |
| 14.A | 14.06.2024 | Robin Sacher                 | Deathcounter        | 120'          |

Total: 17 Stunden

## 3 Entscheiden

Wir haben uns dazu entschieden das Feedback, wenn der Spieler ein Fehler macht, weg zu lassen. Dazu haben wir uns entschieden, weil es selbsterklärend ist, was man falsch gemacht hat.

## 4 Realisieren

| AP-№ | Datum      | Zuständig                    | geplante Zeit | tatsächliche Zeit |
| ---- | ---------- | ---------------------------- | ------------- | ----------------- |
| 1.A  | 17.05.2024 | Elias Spycher                | 30'           | 40'               |
| 2.A  | 17.05.2024 | Elias Spycher                | 30'           | 20'               |
| 3.A  | 24.05.2024 | Robin Sacher                 | 20'           | 20'               |
| 5.A  | 24.05.2024 | Elias Spycher                | 60'           | 60'               |
| 6.A  | 17.05.2024 | Robin Sacher                 | 90'           | 60'               |
| 7.A  | 17.05.2024 | Elias Spycher                | 30'           | 10'               |
| 8.A  | 24.05.2024 | Elias Spycher / Robin Sacher | 60'           | 60'               |
| 9.A  | 24.05.2024 | Robin Sacher / Elias Spycher | 60'           | 30'               |
| 10.A | 17.05.2024 | Robin Sacher                 | 20'           | 10'               |
| 11.A | 24.05.2024 | Robin Sacher / Elias Spycher | 120'          | 120'              |
| 11.B | 24.05.2024 | Robin Sacher                 | 120'          | 240'              |
| 11.C | 24.05.2024 | Elias Spycher                | 120'          | 240'              |
| 12.A | 31.05.2024 | Elias Spycher                | 30'           | 30'               |
| 12.B | 31.05.2024 | Elias Spycher                | 30'           | 30'               |
| 12.C | 31.05.2024 | Elias Spycher                | 30'           | 30'               |
| 13.A | 31.05.2024 | Robin Sacher                 | 40'           | 25'               |
| 14.A | 31.05.2024 | Robin Sacher                 | 120'          | 100'              |

## 5 Kontrollieren

### 5.1 Testprotokoll

| Test-№ | TC-№ | Datum      | Resultat | Tester       | Bemerkungen         |
| ------ | ---- | ---------- | -------- | ------------ | ------------------- |
| 1.     | 1.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 2.     | 2.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 3.     | 3.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 4.     | 4.1  | 14.06.2024 | NOK❌    | Robin Sacher | nicht implementiert |
| 5.     | 5.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 6.     | 6.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 7.     | 7.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 8.     | 8.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 9.     | 9.1  | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 10.    | 10.1 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 11.    | 11.1 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 12.    | 11.2 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 13.    | 11.3 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 14.    | 12.1 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 15.    | 12.2 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 16.    | 12.3 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 17.    | 13.1 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |
| 18.    | 14.1 | 14.06.2024 | OK ✅    | Robin Sacher | -                   |

Alle Testfälle bis auf das Feedback bei Fehler werden erfüllt. Das Feedback haben wir nicht implementiert. Somit ist das Projekt abgeschlossen.

## 6 Auswerten

- Robin Sacher: https://portfolio.bbbaden.ch/view/view.php?t=5b5992608008fad97949
- Elias Spycher: https://portfolio.bbbaden.ch/view/blocks.php?id=34333
