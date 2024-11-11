using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Ubung8
{
    internal class Program
    {
        static void Main(string[] args)
        {

                 
//            1.Ganzzahlige Datentypen(Integer Types)

//    int(System.Int32)
//        Größe: 32 Bit
//        Bereich: von - 2.147.483.648 bis 2.147.483.647
//        Verwendung: Zur Speicherung von Ganzzahlen in den meisten Anwendungen.Ideal für Zählungen, Identifikatoren, Indizes und ähnliche Daten.
//        Anwendungsbereiche: Geschäftsanwendungen, Spiele, Operationen, bei denen mit ganzen Zahlen gearbeitet wird.

//    long(System.Int64)
//        Größe: 64 Bit
//        Bereich: von - 9.223.372.036.854.775.808 bis 9.223.372.036.854.775.807
//        Verwendung: Zur Speicherung großer Ganzzahlen. Ideal, wenn int zu klein ist, z. B.bei der Arbeit mit großen Dateien oder Datenmengen.
//        Anwendungsbereiche: Finanzen, Datenbanken, Verarbeitung großer Datenmengen.

//    short(System.Int16)
//        Größe: 16 Bit
//        Bereich: von - 32.768 bis 32.767
//        Verwendung: Wenn kleine Ganzzahlen benötigt werden, z.B.zur Speicherersparnis in eingebetteten Systemen.
//        Anwendungsbereiche: Elektronik, eingebettete Systeme, Anwendungen mit begrenzten Ressourcen.

//    byte(System.Byte)
//        Größe: 8 Bit
//        Bereich: von 0 bis 255
//        Verwendung: Zum Speichern kleiner Ganzzahlen ohne Vorzeichen, z. B.Binärdaten, RGB - Farben.
//        Anwendungsbereiche: Computergrafik, Dateioperationen, eingebettete Systeme.

//    sbyte(System.SByte)
//        Größe: 8 Bit
//        Bereich: von - 128 bis 127
//        Verwendung: Wenn kleine Ganzzahlen mit negativen Werten benötigt werden.
//        Anwendungsbereiche: Spezialisierte Systeme, z. B.Systeme mit begrenztem Speicher.

//2.Gleitkommazahl - Datentypen(Floating - Point Types)

//    float(System.Single)
//        Größe: 32 Bit
//        Bereich: von ~±1,5 × 10 ^ -45 bis ±3,4 × 10 ^ 38
//        Genauigkeit: Ca. 7 signifikante Stellen
//        Verwendung: Zum Speichern von Gleitkommazahlen, bei denen eine höhere Präzision als bei Ganzzahlen benötigt wird, aber Speicher wichtig ist.
//        Anwendungsbereiche: Computergrafik, Simulationen, Computerspiele.

//    double(System.Double)
//        Größe: 64 Bit
//        Bereich: von ~±5,0 × 10 ^ -324 bis ±1,7 × 10 ^ 308
//        Genauigkeit: Ca. 15 - 16 signifikante Stellen
//        Verwendung: Am häufigsten verwendeter Typ für Gleitkommazahlen, besonders bei wissenschaftlichen und technischen Berechnungen.
//        Anwendungsbereiche: Physik, mathematische Berechnungen, Finanzen, Ingenieurwesen.

//    decimal(System.Decimal)
//        Größe: 128 Bit
//        Bereich: von ±1,0 × 10 ^ -28 bis ±7,9 × 10 ^ 28
//        Genauigkeit: Ca. 28 - 29 signifikante Stellen
//        Verwendung: Für präzise Berechnungen, insbesondere in der Finanzwelt, wo eine exakte Darstellung von Dezimalwerten entscheidend ist(z.B.bei Währungsoperationen).
//        Anwendungsbereiche: Finanzen, Buchhaltung, Geldberechnungen.

//3.Boolesche Datentypen(Boolean Type)

//    bool(System.Boolean)
//        Größe: 1 Bit(in der Praxis als 1 Byte verwaltet)
//        Bereich: true oder false
//        Verwendung: Zum Speichern von logischen Werten(wahr / falsch).Verwendet in bedingten Anweisungen, Schleifen und anderen logischen Konstruktionen.
//        Anwendungsbereiche: Jedes Programmiergebiet, z. B.Steuerung des Programmflusses, Entscheidungsalgorithmen.

//4.Zeichen - Datentypen(Character Type)

//    char(System.Char)
//        Größe: 16 Bit(Unicode)
//        Bereich: Alle Unicode-Zeichen(von 0 bis 65.535)
//        Verwendung: Zum Speichern einzelner Zeichen. Wird in der Textverarbeitung und zur Darstellung von Symbolen verwendet.
//        Anwendungsbereiche: Textverarbeitung, Benutzeroberflächen, Operationen auf Zeichenketten.

//5.Text - Datentypen(Text Type)

//    string(System.String)
//        Größe: Hängt von der Anzahl der Zeichen ab(jedes Zeichen belegt 16 Bit)
//        Bereich: Eine Folge von Unicode-Zeichen
//        Verwendung: Zum Speichern von Zeichenketten. Wird in Textoperationen, Benutzerkommunikation und Textanalysen verwendet.
//        Anwendungsbereiche: Textverarbeitung, Benutzeroberflächen, Datenbanken, Dateioperationen mit Textdateien.

//6.Datums - und Zeit - Datentypen(Date and Time Types)

//    DateTime(System.DateTime)
//        Größe: 64 Bit
//        Bereich: 1.Januar 0001 bis 31.Dezember 9999
//        Verwendung: Speichert Daten und Uhrzeiten. Ideal für die Arbeit mit Kalendern, Ereignissen, Terminen und Zeitplänen.
//        Anwendungsbereiche: Geschäftsanwendungen, Zeitpläne, Event - Management, Buchungssysteme.

//7.Aufzählungstypen(Enumerations)

//    enum (System.Enum)
//        Größe: Abhängig vom Basistyp(standardmäßig int)
//        Bereich: Eine konstante Menge definierter Elemente
//        Verwendung: Ermöglicht die Definition einer benannten Menge von Konstanten, was die Arbeit mit Werten in einem begrenzten Satz erleichtert.Wird verwendet, um Optionen, Zustände oder Modi darzustellen.
//        Anwendungsbereiche: Computerspiele, Zustandssysteme, Konfigurationssysteme, Maschinensteuerungen.

//8. Referenzdatentypen (Reference Types)

//    object (System.Object)
//        Größe: Abhängig vom System
//        Bereich: Der Basistyp für alle Datentypen in C#. Kann jeden Wert speichern.
//        Verwendung: Beliebige Referenztypen (Klassen, Schnittstellen). Hauptsächlich für die Arbeit mit dynamisch typisierten Daten verwendet.
//        Anwendungsbereiche: Allgemeine Anwendungen, Datenbanken, Arbeit mit verschiedenen Datentypen.

//9. Nullable-Typen (Nullable Types)

//    Nullable<T>
//        Verwendung: Ermöglicht das Speichern von null-Werten in Werttypen (z.B. int?). Nützlich















    }
    }
}
