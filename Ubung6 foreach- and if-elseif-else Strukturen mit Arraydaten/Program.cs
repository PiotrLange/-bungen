using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ubung6_foreach__and_if_elseif_else_Strukturen_mit_Arraydaten
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Programm zur Berechnung des Durchschnitts der Punkte und Zuweisung einer Note basierend auf dem Durchschnitt 

            int examAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            // Student Name
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            int[] studentScores = new int[10];

            string currentStudentLetterGrade = "";

            // Berichtsheader (Kopfzeile) in die Konsole. "\t"- Macht einen Abstand zwischen den Spalten..
            Console.WriteLine("Student\t\tPunkten\tGrade\n");

            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                // Initialisiere/Setze die Summe der bewerteten Aufgaben zurück.
                int sumAssignmentScores = 0;

                // Initialisiere/Setze den berechneten Durchschnitt der Prüfungs- und Zusatzpunkte zurück.
                decimal currentStudentGrade = 0;

                // Initialisiere/Setze einen Zähler für die Anzahl der Aufgaben zurück.
                int gradedAssignments = 0;

                // loop Durchlaufe das Punktarray und führe Berechnungen für den aktuellen Studenten durch
                foreach (int score in studentScores)
                {
                    // Erhöhe den Aufgabenzähler.
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        // Füge die Prüfungsnote zur Summe hinzu.
                        sumAssignmentScores += score;

                    else
                        // Füge die Zusatzpunkte zur Summe hinzu - Bonuspunkte entsprechen 10 % der Prüfungsnote.
                        sumAssignmentScores += score / 10;
                }

                currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");  Erstellt Spalten für Daten, wobei \t den Abstand festlegt.
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
            }

            // erforderlich für das Ausführen in VS Code (hält das Ausgabefenster geöffnet, um Ergebnisse anzuzeigen)
            Console.WriteLine("\n\rPress the Enter key to continue");
            Console.ReadLine();






        }
    }
}




