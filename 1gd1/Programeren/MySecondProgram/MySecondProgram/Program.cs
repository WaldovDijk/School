using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySecondProgram
{
	class Program
	{
		static void Main( string[] args )
		{
			//Opdracht1();			
			//Opdracht2();			
			//Opdracht3();			
			//Opdracht4();			
			Opdracht5();			
			Opdracht6();			
			Opdracht7();			
			Opdracht8();			
			Opdracht9();			
			Opdracht10();			
		}

		//Variabelen: Hoeveel studenten zitten er in de klas? Welk datatype gebruik je daarvoor (zo klein mogelijk)?
		public static void Opdracht1()
		{
			
			Console.WriteLine( "------------- Opdracht 1 -------------" );
			Console.WriteLine( "Hoeveel studenten zitten er in de klas?" );

            sbyte leerlingAantal = 28;

			Console.WriteLine( "Er zitten " + leerlingAantal + " in de klas." );

			VolgendeOpdracht();
			
			
		}



		//Variabelen: Vind je programmeren leuk? Welke antwoorden moet je invullen om de zin te laten kloppen?
		public static void Opdracht2()
		{
			
			 
			Console.WriteLine( "------------- Opdracht 2 -------------" );			
			Console.WriteLine( "Vind je programmeren leuk?" );
			
			bool vindJeProgrammerenLeuk;
			vindJeProgrammerenLeuk = true;

			if (vindJeProgrammerenLeuk == true)
			{
				Console.WriteLine( "Gelukkig maar, dan zit je op de juiste plek!" );
			}
			else
			{
				Console.WriteLine( "Is deze studie dan wel een handige keuze?" );
			}
			
			VolgendeOpdracht();
			
			
		}




		//Variabelen: Welke variabele type heb je nodig om de waarde van pi te bewaren? En geef de variabele de goede waarde.
		//(de waarde van pi --> google is your friend!)
		public static void Opdracht3()
		{
			
			
			Console.WriteLine( "------------- Opdracht 3 -------------" );

			double pi = 3.14159265359;

			Console.WriteLine( "De waarde van pi is: " + pi );

			VolgendeOpdracht();
			
			
		}





		//Variabelen: Welke variabele type heb je nodig om de som te laten kloppen?
		public static void Opdracht4()
		{
			
			
			Console.WriteLine( "------------- Opdracht 4 -------------" );

			int mijnHeleGetal = 25;
			double mijnKommaGetal = 4.6d;

			double mijnUitkomst = mijnHeleGetal + mijnKommaGetal;

			Console.WriteLine( "De uitkomst van mijnUitkomst is " + mijnUitkomst );

			VolgendeOpdracht();

			
		}




		//Operatoren: Welk percentage is 128 van 2056? Maak de berekening. LET OP! Er komt een komma getal uit!
		public static void Opdracht5()
		{
			

			Console.WriteLine( "------------- Opdracht 5 -------------" );

			float percentage = 100f / 2056f * 128f;

			Console.WriteLine( "128 is " + percentage + "% van 2056");

			VolgendeOpdracht();

			
		}




		//Operatoren: Verander alle ??? in de juiste operatoren.
		public static void Opdracht6()
		{
			

			Console.WriteLine( "------------- Opdracht 6 -------------" );

			Console.WriteLine( "Geef het eerste getal op:" );
			int getal1 = Convert.ToInt32( Console.ReadLine() );
			Console.WriteLine( "Geef het tweede getal op:" );
			int getal2 = Convert.ToInt32( Console.ReadLine() );

			//Optellen
			int uitkomst1 = getal1 + getal2;
			Console.WriteLine( getal1 + " + " + getal2 + " = " + uitkomst1 );

			//Aftrekken
			int uitkomst2 = getal1 - getal2;
			Console.WriteLine( getal1 + " - " + getal2 + " = " + uitkomst2 );

			//Vermenigvuldigen
			int uitkomst3 = getal1 * getal2;
			Console.WriteLine( getal1 + " x " + getal2 + " = " + uitkomst3 );

			//Delen
			float uitkomst4 = (float) getal1 / getal2;
			Console.WriteLine( getal1 + " / " + getal2 + " = " + uitkomst4 );

			VolgendeOpdracht();

			
		}




		//If's: De som mag alleen uitgevoerd worden als de deler geen 0 is
		public static void Opdracht7()
		{
			

			Console.WriteLine( "------------- Opdracht 7 -------------" );
			Console.WriteLine( "Vul een getal in" );

			int getal = 1234567890;
			int deler = Convert.ToInt32( Console.ReadLine() );

			if ( deler > 0 )
			{
				float uitkomst = (float)getal / deler;

				Console.WriteLine( "De uitkomst van de som " + getal + " / " + deler + " = " + uitkomst );
			}
			else
			{
				Console.WriteLine( "Ik kan niet door nul delen!" );
			}

			VolgendeOpdracht();

			
		}


		
		//If's: Maak een if structuur die kijkt
			//- Of de deur open is (als open is ingevuld)
			//- Of de deur gesloten is (als gesloten is ingevuld)
			//- Anders is de status van de deur ongeldig, zeg dit tegen de gebruiker. (als er iets anders is ingevuld dan open of gesloten)
		public static void Opdracht8()
		{
			

			Console.WriteLine( "------------- Opdracht 8 -------------" );
			Console.WriteLine( "Is de deur open? Vul open of gesloten in." );
			string deurStatus = Console.ReadLine();

			//??? Maak hier if structuur aan
            if ( deurStatus == "open" ) 
            {
                Console.WriteLine("De deur is open.");
            }
            else if ( deurStatus == "gesloten")
            {
                Console.WriteLine("De deur is gesloten.");
            }
            else
            {
                Console.WriteLine("De status van de deur is onbekent.");
            }

			VolgendeOpdracht();
			 
			
		}




		//if's: Maak een if structuur die vertelt of een willekeurig gekozen getal (de variabele --> getal):
			//- tussen de 0 en 4 is
			//- tussen de 5 en 10 is
			//- tussen de 11 en 15 is
		public static void Opdracht9()
		{
			
			
			Console.WriteLine( "------------- Opdracht 9 -------------" );
			
			Random rand = new Random();
			int getal = rand.Next(0, 15);

			if (getal < 5)
            {
                Console.WriteLine("Je getal is tussen 0 en 4 ({0})", getal);
            }
            else if ( getal < 10 )
            {
                Console.WriteLine("Je getal is tussen 5 en 10 ({0})", getal);
            }
            else if ( getal < 15)
            {
                Console.WriteLine("Je getal is tussen 11 en 15 ({0})", getal);
            }
            VolgendeOpdracht();
			
			
		}

		//Teken eerst een flowchart waarin:
			//- Je eerst gevraagd wordt een naam in te vullen
			//- Je vult de naam in
			//- Er wordt gekeken welke naam (uit de klas) dat is
			//- Elke naam geeft een andere zin terug (In een aaneengesloten if statement, met meerdere else if clausules)
		//Werk vervolgens deze flowchart uit in code
		public static void Opdracht10()
		{
			
			
			Console.WriteLine( "------------- Opdracht 10 -------------" );


            Console.WriteLine("(hoofletter gevoelig)Vul je voornaam in:");
            string userName = Console.ReadLine();
            Console.WriteLine("\n");
 
            //??? Maak hier de if structuur aan
            if (userName == "Waldo van Dijk")
            {
                Console.WriteLine("Rash b Cyka Blyat");
            }
            else if (userName == "Leon")
            {
                Console.WriteLine("Code Kopen?? 60 plat");
            }
            else if (userName == "Dominique")
            {
                Console.WriteLine("Join Discord");
            }
            else if (userName == "Geert")
            {
                Console.WriteLine("Heeee Geerte");
            }
            else if (userName == "Mark")
            {
                Console.WriteLine("Ga nou maar warframe spelen!!");
            }
            else
            {
                Console.WriteLine("Helaas staat jou naam niet geregistreert");
            }
            VolgendeOpdracht();
			 
			
		}

		public static void VolgendeOpdracht()
		{
			Console.WriteLine( "Druk op een toets om verder te gaan met de volgende opdracht." );
			Console.ReadKey();
		}
	}
}
