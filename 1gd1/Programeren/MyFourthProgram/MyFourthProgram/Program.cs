using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyFourthProgram
{
	class Program
	{
        public static int aantal = 0;
        static void Main( string[] args )
		{
			//Opdracht1();
			//WachtOpKey();
			//Opdracht2();
			//WachtOpKey();
			//Opdracht3();
			//WachtOpKey();
			//Opdracht4();
			//WachtOpKey();
			Opdracht5();
            WachtOpKey();
            WachtOpKey( "Zo het programma is afgelopen.Tot ziens!" );
		}

        //Opdracht 1: Maak een functie waarmee je twee getallen bij elkaar optelt, noem de functie Optellen
        //- De getallen geef je mee als twee parameters
        //- De functie geeft het resultaat terug
        public static int Optellen(int v1, int v2)
        {
            return v1 + v2;
        }
        public static void Opdracht1()
		{

			int resultaat = Optellen( 2, 10 );
			Console.WriteLine( "Resultaat 1: " + resultaat );

			resultaat = Optellen( 15, 30 );
			Console.WriteLine( "Resultaat 2: " + resultaat );
		}


        //Opdracht 2:Maak twee functies die twee getallen kunnen vermenigvuldigen met dezelfde naam, Vermenigvuldigen
        //De ene functie krijgt twee hele getallen mee en geeft een heel getal terug
        //De andere functie krijgt twee komma getallen mee en geeft een komma getal terug
        public static int Vermenigvuldigen(int v1, int v2)
        {
            return v1 * v2;
        }
        public static double Vermenigvuldigen(double v1, double v2)
        {
            return v1 * v2;
        }
        
        public static void Opdracht2()
		{
            Console.Clear();
			Console.WriteLine( "De uitkomst van 2 * 5 = " + Vermenigvuldigen( 2, 5 ) );

			Console.WriteLine( "De uitkomst van 3.14d * 2.0d = " + Vermenigvuldigen( 3.14d, 2.0d ) );
		}



		//Opdracht 3: Maak een functie waarmee je kunt uitrekenen hoeveel Geld je hebt als je je geld op een spaarrekening neerzet, het Renteverloop
		// - De functie krijgt drie parameters mee, hoeveel geld je op de rekening hebt, het rentepercentage en de hoeveelheid jaar (standaard voor 5 jaar)
		// - Laat voor elk jaar zien hoeveel geld je op dat moment hebt en welk rentepercentage wordt gebruikt.
		// - Rond het bedrag af op twee decimalen met: Math.Round( hetGetal, 2); //Deze functie returned een afgeronde double met maximaal 2 decimalen!
        public static void Renteverloop(double geld, double rente, int jaar)
        {
            Console.Clear();
            double saldo;
            int i = 1;
            do
            {
                //veranderingsaldo
                saldo = geld * rente;
                //nieuwe geld hoeveelheid
                geld = geld + saldo;
                Console.WriteLine("jaar {0} = {1} ", i , Math.Round(geld, 2));
                i++;               
            }
            while (i <= jaar );

        }
		public static void Opdracht3()
        { 
            
            Renteverloop(300.23d, 0.05d, 5);

            
		}




        //Opdracht 4: Maak een functie die een zin letter voor letter uitprint, noem de functie TypeMachine
        //- De zin geef je als input aan de functie mee als parameter
        //- voor het uitprinten zonder automatisch een nieuwe regel te geven gebruik je: Console.Write( "Wat je wilt uitprinten" );
        //- voor het wachten tot je de volgende letter gaat printen gebruik je: Thread.Sleep( 100 );
        //- Om aan het eind alleen een enter te geven gebruik je: Console.Write("\n");
        public static void TypeMachine(string input)
        {
            foreach (char letter in input)
            {
                Console.Write(letter);
                Thread.Sleep(100);
            }
            Console.Write("\n");
            Console.Write("Wat je wilt uitprinten?\n");
            string print = Console.ReadLine();
            foreach (char letter in print)
            {
                Console.Write(letter);
                Thread.Sleep(100);
            }
            Console.Write("\n");
        }
		public static void Opdracht4()
		{
			TypeMachine( "Print deze zin, letter voor letter." );
            
        }



        //Opdracht 5: Maak een functie die telt hoeveel klinkers er in een zin staan die jij kan intypen, noem de functie TelKlinkers
        //- Als parameter krijgt deze functie een zin mee.
        //- Gebruik voor het vergelijken van 1 character de Equals functie, en enkele quotes om de letter: Equals('a');
        //- Laat de i alleen meetellen als deze niet onderdeel is van de ij
        //- De laatste letter kan ook een i zijn!
        //- Bijvoorbeeld de zin "jij en ik in een bikini" moet 8 klinkers tellen en niet crashen.
        //In de functie Opdracht5 laat je uitprinten: "Er zitten: ... klinkers in de zin"
        public static void TelKlinkers(string ask)
        {
            Console.WriteLine(ask);
            string zin = Console.ReadLine();
            bool ij = false;
            char[] letters = zin.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i].Equals('a') || letters[i].Equals('e') || letters[i].Equals('o') || letters[i].Equals('u'))
                {
                    aantal++;
                    ij = false;
                }
                else if (letters[i].Equals('i'))
                {
                    aantal++;
                    ij = true;
                }
                else if (letters[i].Equals('j') && ij == true)
                {
                    aantal--;
                    ij = false;
                }
                else
                {
                    ij = false;
                }
            }
        }
        public static void Opdracht5()
		{
            TelKlinkers("schrijf een zin op");
            Console.WriteLine("Er zitten: {0} klinkers in de zin", aantal);
		}





		public static void WachtOpKey( string message = "Druk op een toets om door te gaan" )
		{
			Console.WriteLine( message );
			Console.ReadKey();
		}
	}
}
