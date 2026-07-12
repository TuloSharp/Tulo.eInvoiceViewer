# eInvoice PDF Viewer

🇬🇧 English version: [README_EN.md](README_EN.md)

Ein einfaches Open-Source-Tool zum Anzeigen unterstützter eInvoice-XML-Dateien als PDF.

Dieses Projekt wurde entwickelt, um das Öffnen einer unterstützten Rechnungs-XML-Datei zu erleichtern und sie in einer PDF-ähnlichen visuellen Form darzustellen.

Es ist besonders nützlich für Nutzer, die mit strukturierten elektronischen Rechnungsdateien arbeiten und diese schnell in einem lesbaren Dokumentlayout ansehen möchten.

![Image 1](./ReadMeImages/Animation_01.gif)

![Image 2](./ReadMeImages/UiImage01.png)

![Image 3](./ReadMeImages/UiImage02.png)

---

## Was dieses Programm macht

Diese Anwendung ermöglicht es einem Nutzer, eine unterstützte eInvoice-XML-Datei zu öffnen und sie als PDF-Ansicht anzuzeigen.

Der Hauptzweck besteht darin, XML-basierte Rechnungsdaten für Menschen leichter lesbar zu machen.

Das Programm fügt eine Kontextmenü-Aktion hinzu, sodass ein Nutzer mit der rechten Maustaste auf eine unterstützte XML-Rechnungsdatei klicken und sie direkt als PDF-Vorschau öffnen kann.

Diese Funktion ist nur für unterstützte **eInvoices** vorgesehen.  
Sie konvertiert **nicht** beliebige XML-Dateien.  
Nur XML-Dateien, die den unterstützten Rechnungsstandards und -strukturen entsprechen, können korrekt angezeigt werden.

---

## Unterstützte Rechnungsformate

Diese Bibliothek erzeugt PDF-Darstellungen aus XML-eRechnungen in den folgenden Syntaxen:

   - UN/CEFACT Cross Industry Invoice (CII) – z. B. wie bei XRechnung oder ZUGFeRD/Factur-X verwendet (CII-Profil)
   - OASIS UBL (Invoice / CreditNote) – über die UBL-Namespaces cbc und cac

Der Code erkennt automatisch, ob die Eingabe-XML UBL oder CII ist, indem mehrere XPath-Varianten für Schlüsselfelder ausprobiert werden (z. B. Rechnungsnummer, Datum, Verkäufer, Käufer) und die erste passende Variante verwendet wird.

EN 16931 Kontext

EN 16931 definiert das semantische Datenmodell für europäische elektronische Rechnungen und stellt Bindings für UBL und CII bereit.  
Diese Bibliothek führt selbst keine EN-16931-Validierung durch (keine Schema-/Schematron-/Business-Rule-Prüfungen), kann jedoch XML-Rechnungen, die bereits EN-16931-konform sind, visuell in ein lesbares PDF rendern.

---

## Wichtiger Haftungsausschluss

Bitte lies die Hinweis- und Haftungsausschlussinformationen innerhalb der Anwendung.

Du findest sie unter:

**View -> About**

Diese Informationen sind wichtig und sollten vor der Nutzung der Anwendung in produktiven, rechtlichen, geschäftlichen oder compliance-relevanten Szenarien gelesen werden.

Der in der Anwendung angezeigte Haftungsausschluss ist der maßgebliche Hinweis für Nutzung, Einschränkungen und Verantwortung.

---

## Open Source

Dieses Projekt ist Open Source und kann von der Community verwendet, angepasst und verbessert werden.

---

## Anforderungen

| Anforderung | Detail |
|---|---|
| Betriebssystem | Windows x64 |
| Runtime | .NET 8 (muss separat installiert werden) |
| .NET Download | https://dotnet.microsoft.com/en-us/download/dotnet/8.0 |

---

## Erste Schritte

1. Gehe auf die Seite [Releases](../../releases)
2. Lade die neueste `.zip`-Datei herunter
3. Erstelle die Ordnerstruktur wie im Abschnitt [Configuration — end users](#configuration--end-users) beschrieben
4. Entpacke die ZIP-Datei in den Ordner `Tulo.eInvoiceViewer/`
5. Bearbeite deine `appsettings.json` im Ordner `Tulo.eInvoiceViewer-appsettings/` mit deinen Verkäuferdaten und Einstellungen
6. Starte `Tulo.eInvoiceViewer.exe`

Kein Installer erforderlich.

---

## Drittanbieter-Bibliotheken

Dieses Projekt verwendet die folgenden NuGet-Pakete von Drittanbietern:

- PDFsharp-extended (v1.3.0)
- Markdig.Wpf (v0.5.0.1)
- Serilog (v4.2.0)
- tulo.CommonMVVM.WPF (v1.0.0)
- tulo.CoreLib (v1.0.0)
- tulo.LoadingSpinnerControl (v1.0.0)
- tulo.ResourcesWpfLib (v1.0.0)
- tulo.SerilogLib (v1.0.0)
- tulo.XMLeInvoiceToPdf (v1.0.0)

Alle Rechte und Anerkennungen für diese Bibliotheken gehen an ihre jeweiligen Autoren und Maintainer.

Hinweis: Der Quellcode für tulo.XMLeInvoiceToPdf ist im GitHub-Repository verfügbar: https://github.com/TuloSharp/tulo.eInvoiceApp.git

---

## Unterstützte Rechnungstypen

Dieses Projekt ist für XML-Rechnungsdateien vorgesehen, die auf strukturierten eInvoicing-Standards basieren.

Zum Beispiel liegt der Fokus auf Rechnungsformaten im Bereich von:

- CII-Rechnungen
- EN16931-Rechnungsstrukturen
- verwandten unterstützten eInvoice-XML-Formaten

Nur unterstützte XML-Rechnungsstrukturen können korrekt gerendert werden.  
Andere XML-Dateien werden ignoriert oder können nicht als PDF angezeigt werden.

---

## Funktionen

- Unterstützte eInvoice-XML-Dateien als PDF-Ansicht öffnen
- Menschenlesbare Darstellung strukturierter Rechnungsinhalte
- Integration in das Rechtsklick-Kontextmenü des Windows Explorers
- Schnelle Vorschau von Rechnungs-XML-Dokumenten
- Funktioniert mit unterstützten Rechnungsbeispielen aus dem Projekt
- Für praktische Nutzung und leichtes Verständnis entwickelt
- Open Source und für weitere Rechnungsformate erweiterbar

---

## Funktionsweise

Die Anwendung liest eine unterstützte XML-Rechnungsdatei, interpretiert die Rechnungsstruktur und erstellt oder zeigt eine PDF-ähnliche visuelle Darstellung der Rechnung an.

Das bedeutet: Die XML-Datei bleibt die Eingabequelle, aber der Nutzer sieht die Rechnung in einer lesbaren Dokumentform anstelle von rohem XML-Text.

---

## Wichtige Einschränkung

Dieses Tool ist **kein allgemeiner XML-zu-PDF-Konverter**.

Das bedeutet:

- nicht jede XML-Datei kann geöffnet werden
- nicht jedes Business-XML-Format wird unterstützt
- nur unterstützte eInvoice-Rechnungsstrukturen werden voraussichtlich funktionieren

Wenn eine Datei keine gültige unterstützte XML-Rechnungsdatei ist, kann die PDF-Vorschau fehlschlagen oder nicht verfügbar sein.

---

## Beispielhafter Anwendungsfall

Ein Nutzer erhält oder erstellt eine elektronische Rechnung im XML-Format.

Anstatt die rohe XML-Datei in einem Texteditor zu öffnen, kann der Nutzer mit der rechten Maustaste auf die Rechnungsdatei klicken und die Aktion zur PDF-Anzeige auswählen.

Die Anwendung öffnet die Rechnung dann in einer lesbaren, PDF-ähnlichen Darstellung.

Das ist nützlich für:

- das visuelle Prüfen von Rechnungsinhalten
- das Überprüfen von Rechnungsdaten ohne XML lesen zu müssen
- das Testen von Rechnungsbeispielen in der Entwicklung
- das Validieren der praktischen Lesbarkeit erzeugter Rechnungsdateien

---

## Integration ins Kontextmenü

Eine der Hauptfunktionen dieses Projekts ist die Integration in den Windows Explorer.

Eine unterstützte XML-Rechnungsdatei kann mit der rechten Maustaste geöffnet werden, indem die entsprechende Aktion zur PDF-Anzeige ausgewählt wird.

Das macht das Tool für die tägliche Arbeit praktisch, weil der Nutzer das Programm nicht zuerst manuell starten muss.

---

## Beispiel-Rechnungsdateien

Das Projekt kann Beispiel-XML-Rechnungsdateien zu Test- und Demonstrationszwecken enthalten.

Beispieldateien können sich in Ordnern befinden wie:

- `Examples\`

Diese Dateien können beim Build in das Ausgabeverzeichnis kopiert werden, damit sie für Tests und Vorschauen verfügbar sind.

---

## Build- und Entwicklungshinweise

Wenn Beispiel-XML-Dateien im Projekt enthalten sind, ist es nützlich, sie automatisch in den Ausgabeordner zu kopieren.

Beispiel:

```xml
<ItemGroup>
  <None Update="Examples\**\*.xml">
    <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
  </None>
</ItemGroup>
```

---

## Hinweise

- Logging hilft dabei, fehlende Argumente und Probleme mit Dateipfaden zu erkennen.
- Dieses Tool ist für eine einfache und praktische Darstellung eines eInvoice-XML-CII-Formats gedacht.

---

## UI-Icons

Dieses Projekt verwendet Google Material Icons in der Benutzeroberfläche.

Alle Credits gehen an die jeweiligen Autoren und Maintainer.

---

## Support

Dieses Tool ist ein privates Projekt. Wenn es dir hilft, freue ich mich über Unterstützung.

- ☕ [PayPal](https://paypal.me/MarceloGuartanAndrad)
- ⭐ [GitHub](https://github.com/TuloSharp/Tulo.eInvoiceCreatorZUGFeRD.git)

---

## Lizenz

    Apache License, Version 2.0
    https://www.apache.org/licenses/LICENSE-2.0