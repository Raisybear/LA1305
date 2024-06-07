# Projekt-Dokumentation

Elias Spycher und Robin Sacher

| Datum      | Version | Zusammenfassung                                                           |
| ---------- | ------- | ------------------------------------------------------------------------- |
| 10.05.2024 | 0.0.1   | Projektdokumentation erstellt und Phasen I und P von IPERKA abgeschlossen |
| 17.05.2024 | 0.0.2   | Projektdokumentation weiter bearbeitet, Testfällle erstellt und Main Menu + Level Auswahl in Game hinzugefügt, Level 1 teilweise implementiert   |
| 24.05.2024 | 0.0.3   | Projekt weiter verbessert. Audio hinzugefügt. Death-Counter implementiert. Asset hinzugefügt. Level Design verbessert + Level 2 hinzugefügt   |
| 31.05.2024 | 0.0.4   | Projekt weiter verbessert. Animationen hinzugefügt, Levelauswahl aktualisiert, an den Levels weitergebaut.   |
| 07.06.2024 | 0.0.5   | Projekt weiter verbessert. An den Levels weitergebaut.    |
| 07.06.2024 | 1.0.0   | Projekt weiter verbessert. Audio hinzugefügt. Death-Counter implementiert. Asset hinzugefügt. Level Design verbessert + Level 2 hinzugefügt   |




## 1 Informieren

### 1.1 Ihr Projekt

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



✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: _Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️_.

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
| 9.1  | Spiel gestartet, ein Level ausgewäht  | Ausweichen der Hindernisse  | Der Anfang des Levels ist einfach und wird immer schwieriger                        |
| 10.1 | Spiel nicht gestartet                 | Mausklick auf Spiel starten | Die Spielregeln werden im Menu angezeigt                                            |
| 11.1 | Spiel gestartet                       | Level Nr. 1 auswählen       | Das Level sieht einzigartig aus                                                     |
| 11.2 | Spiel gestartet                       | Level Nr. 2 auswählen       | Das Level sieht anders als Level Nr. 1 aus                                          |
| 11.3 | Spiel gestartet                       | Level Nr. 3 auswählen       | Das Level sieht anders als Level Nr. 1 und Nr. 2 aus                                |
| 12.1 | Spiel gestartet                       | Level Nr. 1 auswählen       | Soundtrack startet                                                                  |
| 12.2 | Spiel gestartet                       | Level Nr. 2 auswählen       | Neuer Soundtrack, wlecher sich von Soundtrack Nr. 1 unterscheidet, startet          |
| 12.3 | Spiel gestartet                       | Level Nr. 3 auswählen       | Neuer Soundtrack, wlecher sich von Soundtrack Nr. 1 und Nr. 2unterscheidet, startet |
| 13.1 | Spiel gestartet, ein Level ausgewählt | ESC Taste drücken           | Das Spiel wird pausiert                                                             |
| 14.1 | Spiel gestartet, ein Level ausgewählt | Durch Hinderniss sterben    | Death-Counter wird um 1 erhöht                                                      |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |   14.06.2024    |     Elias Spycher      |       Sprung Funktion        |        30'       |
| 2.A  |   14.06.2024    |     Elias Spycher      |       Sprung Animation       |        10'       |
| 3.A  |   14.06.2024    |     Robin Sacher       |       Level Auswahl          |        20'       |
| 7.A  |   14.06.2024    |     Elias Spycher      |       Sprung Animation       |        10'       |
| 6.A  |   14.06.2024    |     Robin Sacher       |       Menu                   |        90'       |
| 10.A |   14.06.2024    |     Robin Sacher       |       Spielregeln im Menu    |        20'       |
| x.F  |   14.06.2024    |           |              |               |
| x.G  |   14.06.2024    |           |              |               |
| x.H  |   14.06.2024    |           |              |               |
| x.I  |   14.06.2024    |           |              |               |
| x.J  |   14.06.2024    |           |              |               |
| x.K  |   14.06.2024    |           |              |               |
| x.L  |   14.06.2024    |           |              |               |
| x.M  |   14.06.2024    |           |              |               |
| x.N  |   14.06.2024    |           |              |               |
| x.O  |   14.06.2024    |           |              |               |


Total:

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   17.05.2024    |      Elias Spycher     |       30'        |          40'         |
| 2.A  |   17.05.2024    |      Elias Spycher     |       30'        |          20'         |
| 7.A  |   17.05.2024    |      Elias Spycher     |       30'        |          10'         |
| 3.A  |   17.05.2024    |      Robin Sacher      |       20'        |          25'         |
| 6.A  |   17.05.2024    |      Robin Sacher      |       90'        |          60'         |
| 10.A  |  17.05.2024    |      Robin Sacher      |       20'        |          10'         |


✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

## 6 Auswerten

- Robin Sacher: https://portfolio.bbbaden.ch/view/view.php?t=5b5992608008fad97949
- Elias Spycher:
