using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toets
{
    class Program
    {
        private static System.IO.StreamWriter file;

        static void Main(string[] args)
        {

            StartToets();
            WelkeOpdracht("---- Multiple Choice ----");
            MultipleChoice();

            WelkeOpdracht("---- Kennisvragen ----");
            KennisVraag1();
            KennisVraag2();
            KennisVraag3();
            KennisVraag4();
            KennisVraag5();

            WelkeOpdracht("---- Maakvragen ----");
            MaakOpdracht1();
            MaakOpdracht2();
            MaakOpdracht3();
            MaakOpdracht4();
            EindToets();
        }

        ////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////// Begin van de toets ///////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////

        //Vul je naam in: 2 punten waard
        public static void StartToets()
        {
            Naam("Waldo van Dijk");
        }

        //Multiple choice: Elk goed antwoord is 2 punten waard
        //Uncomment de goede antwoorden
        public static void MultipleChoice()
        {

            Vraag("1: Welke antwoorden zijn waar? Meedere mogelijk:");
            //Antwoord("   A - Bij een semantische fout heb je ergens een logische fout gemaakt.");
            Antwoord( "   B - Bij een syntax fout heb je ergens een logische fout gemaakt." );
            Antwoord("   C - De compiler helpt je syntax fouten opsporen.");
            //Antwoord( "   D - De compiler lost semantische fouten voor je op." );


            Vraag("2: Wat is een byte?");
            //Antwoord( "   A - Een komma getal, zoals 1.14f" );
            Antwoord("   B - Een heel getal, zoals 5");
            //Antwoord( "   C - Een woord of zin, zoals \"dit\" " );


            Vraag("3: In een flowchart wat betekent een ruit vorm? ♦");
            //Antwoord( "   A - Een proces" );
            //Antwoord( "   B - Een herhaling" );
            Antwoord("   C - Een beslissing");

            Vraag("4: Welk statement is true?");
            //Antwoord("   A - ( 2 <= 2 )");
            //Antwoord( "   B - ( 7 < 6 )" );
            //Antwoord( "   C - ( 2 > 5 )" );
            Antwoord( "   D - ( 15 != 15 )" );

            Vraag("5: Welk statement is true?");
            //Antwoord("   A - ( (9 < 11) || (2 > 3) )");
            Antwoord( "   B - ( (8 > 10) || (3 < 1) )" );
            //Antwoord( "   C - ( (6 < 2) && (6 < 7) )" );
            //Antwoord( "   D - ( (4 < 8) && (5 < 3) )" );

            Vraag("6: In een for loop, wat geef je NIET mee in de conditie?");
            Antwoord( "   A - Tot welk getal de loop moet itereren." );
            //Antwoord("   B - Wanneer de loop tussentijds zou moeten stoppen.");
            //Antwoord( "   C - Vanaf welk getal de loop moet beginnen met itereren." );
            //Antwoord( "   D - Hoeveel er na elke iteratie bij de loop opgeteld moet worden." );

            Vraag("7: Hoe noem je het als iemand een programma test zonder dat hij weet hoe het zou moeten werken?");
            //Antwoord( "   A - Een white box test" );
            //Antwoord( "   B - Een orange box test" );
            Antwoord("   C - Een black box test");

            Vraag("8: Hoe noem je de int in deze functie declaratie: public static int MijnFunctieNaam() { }");
            //Antwoord("   A - Een return type");
            //Antwoord( "   B - Een parameter" );
            Antwoord( "   C - Een header" );

            Vraag("9: Wat is een enkele = ?");
            Antwoord( "   A - Een vergelijkings operator" );
            //Antwoord("   B - Een assignment operator");
            //Antwoord( "   C - Een variabele" );

            WachtOpInput();
        }

        //Schrijf jouw antwoord op: Een goed antwoord is 5 punten waard
        public static void KennisVraag1()
        {
            Vraag("10: Noem twee redenen waarom een while loop oneindig door kan lopen.");

            Antwoord("1.Omdat het doorloopt tot dat iets true is en als dit niet true is loopt het niet door.\n 2. als je iets verkeert hebt staan in de loop waardoor iets false of true kan worden. ");

            WachtOpInput();
        }

        //Vul jouw antwoord in: Een goed antwoord is 5 punten waard
        public static void KennisVraag2()
        {
            Vraag("11: Wat is een Array? En waarom zou je er een gebruiken?");

            Antwoord("Een array is een plaats waar dingen staan opgeslagen. Je kan een array gebruiken om een Inventory system te maken. hierdoor hoef je niet 4 ints/strings aan te maken ");

            WachtOpInput();
        }

        //Vul jouw antwoord in: Een goed antwoord is 5 punten waard
        public static void KennisVraag3()
        {
            Vraag("12: Wat is het verschil tussen het declareren en het initialiseren van een variabele?");

            Antwoord("Declareren is over een string en Initialiseren gaat over een Int (Value)");

            WachtOpInput();
        }

        //Vul jouw antwoord in: Een goed antwoord is 5 punten waard
        public static void KennisVraag4()
        {
            Vraag("13: Wat is het overloaden van een functie? En wanneer krijg je een ambiguous (ambigue) error?");

            Antwoord("het overloaden van een functie is bijvoorbeeld een 5 invoeren terwijl er maar 4 cijfers in de int zitten. De error krijg je als je 2 dezelfde ints gebruikt voor hetzelfde ding. ");

            WachtOpInput();
        }

        //Vul jouw antwoord in: Een goed antwoord is 5 punten waard
        public static void KennisVraag5()
        {
            Vraag("14: Wat wordt er bedoeld met scope?");

            Antwoord("een area waar in de code werkt.");

            WachtOpInput();
        }

        //Werk jouw antwoord uit: Een goede uitwerking is 10 punten waard
        public static void MaakOpdracht1()
        {
            Vraag("15: Vraag de gebruiker zijn naam in te vullen. ");
            Vraag("Als de naam Rubin is --> zeg dan \"Hallo Docent! Het gaat best goed.\"", true);
            Vraag("Als de naam iets anders is zeg dan \"Hoi naam, leuk je te zien!\"", true);
            Vraag("Let op! De gebruiker kan elke vorm van hoofdletters gebruiken (bijv Rubin, rubin, RUBIN, etc.)", true);


            //Maak hier jouw uitwerking
            string naam;


            Console.WriteLine("Vul je voornaam in:");
            naam = Console.ReadLine().ToLower();

            if (naam == "rubin")
            {
                Console.WriteLine("Hallo Docent! Het gaat best goed.");
            }
            else
            {
                Console.WriteLine("Hoi {0}, leuk je te zien!", naam);
            }


            WachtOpInput();
        }

        //Werk jouw antwoord uit: Een goede uitwerking is 10 punten waard
        public static void MaakOpdracht2()
        {
            Vraag("16: Maak een List met daarin 5 namen van dieren. Noem de List dieren.");
            Vraag("    - Loop vervolgens eerst met een while loop door deze List, print elke iteratie de naam van een dier.");
            Vraag("    - Loop daarna in omgekeerde volgorde door de List met een for loop, print elke iteratie de naam van een dier.");
            Vraag("    - Loop daarna met een foreach weer door de List en print wederom elke iteratie de naam van een dier.");

            //Maak hier jouw uitwerking
            bool oke = true;
            List<string> dieren = new List<string>();
            dieren.Add("Hond");
            dieren.Add("Kat");
            dieren.Add("Eend");
            dieren.Add("Duif");
            dieren.Add("Kip");

            do
            {
                Console.WriteLine(dieren);
                oke = false;
            } while (oke == true);

            foreach (string dier in dieren)
            {
                Console.WriteLine(dier);
            }

            WachtOpInput();
        }

        //Werk jouw antwoord uit: Een goede uitwerking is 10 punten waard
        public static void MaakOpdracht3()
        {
            double uitkomst = 0;

            Vraag("17: Maak een functie waarmee je kunt uitrekenen hoeveel procent een getal van een ander getal is, noem de functie BerekenPercentage.");
            Vraag("    - De functie krijgt twee getallen mee, een getal om het totaal aan te duiden en een getal om het deel aan te duiden, het kunnen beide komma getallen zijn!");
            Vraag("    - De functie geeft het percentage terug.");
            Vraag("     - Voer de functie uit, sla het antwoord op in de variabele uitkomst. (De uitkomst wordt daarmee uitgeprint.)");

            //Voer hier de functie BerekenPercentage uit en sla de uitkomst op in uitkomst
            Console.WriteLine("Voeg een cijfer in");
            double antwoord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("voeg nog een cijfer in");
            double antwoord2 = Convert.ToInt32(Console.ReadLine());
            uitkomst = berekentPercentage(antwoord, antwoord2);
            Antwoord(" Uitkomst is: " + uitkomst);
            
            

            WachtOpInput();
        }
        public static double berekentPercentage(double deel, double totaal)
        {
            return deel / totaal * 100;

        }
        //Werk jouw antwoord uit: Een goede uitwerking is 10 punten waard
        public static int aantal = 0;
        public static int uitkomst = 0;
        public static void TelWoorden(string woorden)
        {
            char[] woord = woorden.ToCharArray();
            for (int i = 0; i < woord.Length; i++)
            {
                if (woord[i].Equals(' '))
                {
                    aantal++;
                    
                }
            }
            uitkomst = aantal + 1;
        }
        public static void MaakOpdracht4()
        {
            

            Vraag("18: Maak een functie die de hoeveelheid woorden telt, noem de functie TelWoorden");
            Vraag("    - De functie krijgt als parameter de zin mee");
            Vraag("    - De functie geeft het aantal woorden terug");

            Vraag("    - Vraag eerst in deze functie (MaakOpdracht4) aan de gebruiker om een zin in te vullen.");
            Vraag("    - Roep vervolgens de Telwoorden functie aan en sla de uitkomst op in de variabele uitkomst.");


            //Roep hier de functie Telwoorden aan met de input van de gebruiker, sla de uitkomst op in de variabele uitkomst
            Console.WriteLine("Vul een zin in:");
            string zin = Console.ReadLine();
            TelWoorden(zin);
            Console.WriteLine("Er zitten {0} woorden in de zin", uitkomst);
            WachtOpInput("Dit is het einde van de toets.");
        }

        ////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////// Einde van de toets ///////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////
        //--------------------------------------------------------------------------------------------//

        //--------------------------------------------------------------------------------------------//
        ////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////// Functies voor het runnen van de toets /////////////////
        ////////////////////////////////////////////////////////////////////////////////////
        public static void Naam(string naam)
        {
            string klas = "1GD";
            string datum = "04-11-2016";
            string versie = "1";
            file = new System.IO.StreamWriter("../../" + klas + " " + naam + " " + datum + " versie " + versie + ".txt");

            Console.WriteLine("----- Welkom: " + naam + " -----");
            Console.WriteLine("Dit is de toets van Programmeren 1 voor de klas: " + klas + " op datum: " + datum);

        }

        public static void EindToets()
        {

            string zin = "----- Inleverinstructies: -----";
            WelkeOpdracht(zin);

            zin = "1. Controleer of je je naam hebt ingevuld in de code. (Functie StartToets)";
            WelkeOpdracht(zin);

            zin = "2. Controleer of je alle vragen hebt beantwoord. (9 Multiple choice, 4 kennis vragen en 4 maak vragen)";
            WelkeOpdracht(zin);

            zin = "3. Sluit Visual studio af en hernoem de hoofdmap naar jouw naam.";
            WelkeOpdracht(zin);

            zin = "4. Lever de hele map in via Filezilla/ftp/Netwerkschijf op: ";
            WelkeOpdracht(zin);

            zin = "5. INLEVERMAP 16-17\\GA & GD\\Jaar 1\\Periode 1\\1GD Programmeren 1\\1GD1\\Toets";
            WelkeOpdracht(zin);

            zin = "BELANGRIJK: Losse code bestanden en mappen zonder naam worden niet nagekeken!";
            WelkeOpdracht(zin);

            file.Close();

            WachtOpInput("\nDruk op een toets om het programma af te sluiten");

        }

        public static void WelkeOpdracht(string opdracht)
        {
            Schrijf(opdracht + "\n");
        }

        public static void Vraag(string vraag, bool regelWit = true)
        {
            string wit = (regelWit) ? "\n" : "";
            Schrijf(wit + vraag);
        }

        public static void Antwoord(string antwoord)
        {
            Schrijf(antwoord);
        }

        public static void Schrijf(string zin)
        {
            Console.WriteLine(zin);
            file.WriteLine(zin);
        }

        public static void WachtOpInput(string zin = "Druk op een toets om verder te gaan.")
        {
            Console.WriteLine("\n" + zin);
            Console.ReadKey();
            ClearScreen();
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }
    }
}
