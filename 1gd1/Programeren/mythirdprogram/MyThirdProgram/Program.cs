using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyThirdProject
{
	class Program
	{
        private static int correct = 0;
        private static Random rand;

		static void Main( string[] args )
		{
			rand = new Random();

			//Opdracht1();
			//BlijfWachtenOpKey();

			//Opdracht2();
			//BlijfWachtenOpKey();

			//Opdracht3();
			//BlijfWachtenOpKey();

			//Opdracht4();
			//BlijfWachtenOpKey();

			//Opdracht5();
			//BlijfWachtenOpKey();

			//Opdracht6();
			//BlijfWachtenOpKey();

			//Opdracht7();
			//BlijfWachtenOpKey();

			//Opdracht8();
			//BlijfWachtenOpKey();

			Opdracht9();
			BlijfWachtenOpKey();

		}

		//While: Maak een while die 10 keer uitprint "Die while is best makkelijk" met het nummer van de iteratie ervoor geplaatst
		// vb:	1. Die while is best makkelijk
		//		2. Die while is best makkelijk
		//		etc
		public static void Opdracht1()
		{
			Console.WriteLine( "---  Opdracht 1  ---" );

            int eazy = 1;

            while (eazy <11 )
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("{0}. Die while is best makkelijk", eazy);
                eazy++;
            }

		}

		//While: Maak een while die blijft doorvragen om een zeezoogdier in te vullen totdat iemand "dolfijn" heeft ingetypt
		public static void Opdracht2()
		{

            string zoogdier;

            do
            {
                Console.Clear();
                Console.WriteLine("---  Opdracht 2  ---/n");
                Console.WriteLine("Vul een zoogdier in:");
                zoogdier = Console.ReadLine().ToUpper();

                if (zoogdier == "DOLFIJN")
                {
                    correct++;
                }
            } while (correct == 0);

        }

		//While: Maak een while die aftelt van 5 naar 1 (met een writeline), waarna je "Boem" uitprint op het scherm
		public static void Opdracht3()
		{
            Console.Clear();
			Console.WriteLine( "---  Opdracht 3  ---" );

            int boem = 5;

            do
            {

                Console.WriteLine("{0}", boem);
                boem--;
                Console.Beep();
                System.Threading.Thread.Sleep(1000);


            } while (boem >= 1);

            Console.WriteLine("boem");

        }



		//For: Maak een for loop die optelt van 3 tot 12, elke iteratie WriteLine je "Die for is ook wel eenvoudig"
		public static void Opdracht4()
		{
            Console.Clear();
            Console.WriteLine( "---  Opdracht 4  ---" );
            for (int i = 3; i <= 11; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("{0}. Die for is ook wel eenvoudig",i);
            }

        }

		//For: Maak een for loop om de if structuur heen die aftelt van 10 tot 0		
		public static void Opdracht5()
		{
            Console.Clear();
            Console.WriteLine( "---  Opdracht 5  ---" );

			
			int getal;

            for (getal = 10; getal >= 1; getal--)
            {
                if ((getal % 2) == 0)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(getal + " is even");
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine(getal + " is oneven");
                }
            }
			//Eindig de for loop hier
			

		}

		//For: Maak een for loop die van 0 tot de Lengte van de namen Array loopt, WriteLine elke naam.
		public static void Opdracht6()
		{
            Console.Clear();
            string[] namen = { "Jan", "Piet", "Joris", "Corneel" };

            //Maak de for loop hier aan
            for (int i = 0; i < namen.Length; i++)
            {
                System.Threading.Thread.Sleep(1000);
                string s = namen[i];
                Console.WriteLine(s);
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine( "Die hebben baarden. Die varen mee!" );
		}

		//Array: Maak een Array aan waarin je 5 nummers stopt, tel met een for loop alle nummers bij elkaar op
		public static void Opdracht7()
		{
            Console.Clear();
            Console.WriteLine( "---  Opdracht 7  ---" );

            int[] namen = { 1, 5, 25,2424, 241513 };

            int totaal = 0;
            //Maak de for loop hier aan
            for (int i = 0; i < namen.Length; i++)
            {
                System.Threading.Thread.Sleep(1000);
                totaal += namen[i];

            
                Console.WriteLine(totaal);

            }

          }


		//Array en for:
		//- Maak een for loop waarmee je 5 namen kunt invullen (met ReadLine)
		//- Maak daaronder een for loop waarmee je kijkt welke naam het langst is (Je kunt de lengte van een string opvragen met stringvariabelenaam.Length, net als de lengte van een Array)
		//- WriteLine de langste naam
		public static void Opdracht8()
		{
            Console.Clear();
            Console.WriteLine("---  Opdracht 8  ---");
            string lengte = "";
            string[] namen = new string[5];
            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine("vul een naam in...");
                namen[i] = Console.ReadLine();
            }
            for (int i = 0; i < namen.Length; i++)
            {
                if (lengte.Length < namen[i].Length)
                {
                    lengte = namen[i];
                }
            }
            Console.WriteLine("longest name is " + lengte);
        }
    

		//Array en foreach:
		//- Vul een Array met 50 willekeurige getallen (Gebruik daar de functie krijgWillekeurigGetal voor, die returned een willekeurig getal, boek hoofdstuk 6)
		//- Loop met een foreach door de array en WriteLine of dat getal even of oneven is (Zie opdracht 5)
		public static void Opdracht9()
		{
            Console.Clear();
			Console.WriteLine( "---  Opdracht 9  ---" );


            //int krijgWillekeurigGetal;
            
            int[] cijfer = new int[50];
            //Random krijgWillekeurigGetal = new Random();
            for (int i = 0; i < cijfer.Length; i++)
            {
                Console.WriteLine("cijfer...",i); 
                cijfer[i] = Convert.ToInt32(Console.ReadLine());
            }
            int krijgWillekeurigGetal = rand.Next(0, cijfer.Length);
            Console.WriteLine("random number is " + krijgWillekeurigGetal);
            Console.WriteLine("Druk op een toets om verder te gaan.");
            Console.ReadKey();
        }

		public static int krijgWillekeurigGetal()
		{
			return rand.Next( 100 );
		}


		public static void BlijfWachtenOpKey()
		{
			Console.WriteLine( "" );
			Console.WriteLine( "Druk op een toets om verder te gaan." );
			Console.ReadKey();
			Console.WriteLine( "" );

		}





	}
}
