
# C# & ASP .NET 101

![ASP .NET](https://github.com/christopherstock/AspDotNetPrimer/raw/master/_ASSET/readme/logo_aspdotnet.png)

Dieser Workshop behandelt die wichtigsten Grundlagen von **Microsoft .NET Core** sowie der Programmiersprache **C#**.
 Mit Hilfe des DotNet CLI Befehls und des .NET-Paketmanagers **NuGet** erstellen wir einen **ASP .NET** Backendservice
 von Grund auf. Entwickelt wird eine Serverapplikation, mit der auf Knopfdruck ein Witz aus der **International Chuck
 Norris Database** angefordert und in unserer Anwendung angezeigt wird. Für das Handling der HTTP-Request- u. -Responses
 zur externen Chuck Norris Datenbank soll eine moderne HTTP-Bibliothek aus der **NuGet Gallery** verwendet werden.

<hr>

## Tech Stack

- .NET Core 3.1 SDK
- NUnit 3.12.0
- System.Net.Http 4.3.4 **(??)**

<hr>

## Projekt-Setup

### 1. DotNet-Projekt anlegen

Nach der Installation des **.NET Core SDKs** können Sie auf der Konsole den Befehl `dotnet` ausführen.

Wechseln Sie in einen beliebigen Ordner und erstellen Sie mit dem folgenden `dotnet` Kommando einen neuen Ordner
 mit dem Namen `AspDotNetPrimer` der das Grundgerüst einer **ASP .NET** Anwendung beinhaltet:
 
`dotnet new webapp -o AspDotNetPrimer`


### 2. Entwicklungszertifikat akzeptieren

Damit der **ASP .NET** Backend-Service korrekt auf dem lokalen Rechner erreicht werden kann, muss mit dem folgenden 
 Befehl dem hiermit verbundenen HTTPS-Entwicklungszertifikat vertraut werden:

`dotnet dev-certs https --trust`


### 3. Bauen und Starten der Anwendung

Mit dem folgenden Befehl starten Sie den ASP .NET Server. Die Option `watch` bewirkt, dass das Projekt bei Veränderungen
 am Projektcode neu gebaut wird:

`dotnet watch run`

Die ASP .NET Serveranwendung ist erreichbar unter:

`https://localhost:5001`



















## Development

Die folgenden Aufgaben können im Rahmen eines Coding Dojos oder im Workshopformat durchgeführt werden:

1. Ändern Sie den Begrüßungstext auf der Startseite.
2. Erstellen Sie neben den vorgegebenen Seiten **Home** und **Privacy** eine weitere Seite **Joke**.




![NuGet](https://github.com/christopherstock/DotNetPrimer/raw/master/_ASSET/readme/logo_nuget.png)






### 4. Projektstruktur

### 4.1. Hauptklasse

Die Hauptklasse und deren statische **main**-Methode stellt den Einstieg in unsere Anwendung dar. Die Hauptklasse wurde
 von Gradle erstellt unter:

`src/main/java/de/mayflower/DotNetPrimer/App.java`

Alle Sourcecodes für das Projekt siedeln somit an unter:

`src/main/java`

Es empfiehlt sich, diesen Pfad in der IDE Ihrer Wahl explizit als **Sources Root** zu definieren.

![NUnit](https://github.com/christopherstock/DotNetPrimer/raw/master/_ASSET/readme/logo_nunit.png)

### 4.2. Tests

Ein Beispiel JUnit-Test wurde von Gradle bereits erstellt unter:

`src/test/java/de/mayflower/DotNetPrimer/AppTest.java`

Alle JUnit-Tests siedeln an unter:

`src/test/java`

Es empfiehlt sich, diesen Pfad in der IDE Ihrer Wahl explizit als **Test Resources Root** zu definieren.







### 3. Kompilieren und starten der Anwendung und der Tests

### 3.1. Anwendung kompilieren und starten

Der folgende Befehl kompiliert die Projektsources und startet die Anwendung:

`gradle run`

In der Konsolenausgabe sollte nun ein `Hello world.` zu sehen sein.


### 3.2. Tests

Alle JUnit-Tests können mit dem folgenden Befehl ausgeführt werden:

`gradle test`

Laufen alle Tests korrekt durch, so wird lediglich `BUILD SUCCESSFUL` auf der Konsole ausgegeben. Es erfolgt keine
 explizite Ausgabe der einzeln durchgeführten Tests.

<hr>

![The International Chuck Norris Database](https://github.com/christopherstock/DotNetPrimer/raw/master/_ASSET/readme/chuck.jpg)





### Obsolete:

1. Installieren Sie die aktuellste Version des Pakets **HTTP??** aus der **NuGet Gallery**.


2. Instanziieren Sie die neue Klasse `AppFrame` in der `main`-Methode und rufen Sie deren nicht-statischer Methode
 `show()` auf.
3. Erstellen und Konfektionieren Sie eine Instanz von `JFrame` im Konstruktor der Klasse `AppFrame` und fügen Sie dem
 `JFrame` eine Instanz von `JPanel` hinzu. 
4. Erstellen und Konfektionieren Sie einen `JButton` und ein `JTextField` und fügen Sie die beiden Objekte zum
 `JPanel` hinzu. Das Textfeld soll `read-only` sein.
5. Fügen Sie dem Button einen `ActionListener` hinzu, als der die Klasse `AppFrame` fungieren soll.
 Beim Klick auf den `JButton` soll vorerst eine Ausgabe auf der Ausgabekonsole erscheinen.
6. Installieren Sie die aktuellste Version der Bibliothek `google-http-client` aus dem Maven Repository via Gradle.
7. Erstellen Sie beim Klick auf den Button einen GET-Request zum Requesten eines zufälligen Witzes aus der 
 **International Chuck Norris Database** unter der URL `http://api.icndb.com/jokes/random`.
8. Geben Sie den Response Body als String in der Konsole aus.
9. Fügen Sie das automatische Parsen des Response Bodies in eine Instanz der neuen Klasse **JokeResponse** hinzu.
 Diese Datenklasse soll die Struktur des JSON-Response-Bodies repräsentieren.
10. Zeigen Sie den Witz im Ausgabefeld an.
11. Lagern Sie die Funktionalität des Request- und des Response-Handlings in eine neue Klasse API aus.
