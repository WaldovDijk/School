using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Speech.Synthesis;

namespace Text
{
    class Program
    {
        public static int correct = 0;
         public static void Main(string[] args)
         {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            //Strings:
            string Player_Gender;
             string Player_Name;
             string Input;
             string Answer = "{0} the {1} ruski player. ";

            do
            {
                wait();
                 Console.WriteLine("Welcome to Ruski Adventure Game.\n");
                speech.Speak("Welcome to Ruski Adventure Game.\n");
                wait();
                 Console.WriteLine("In game we give you situation.");
                speech.Speak("In game we give you situation.");
                wait();
                 Console.WriteLine("Every situation will have same pattern.");
                speech.Speak("Every situation will have same pattern.");
                wait();
                 Console.WriteLine("1. Situation will be presented.");
                speech.Speak("1. Situation will be presented.");
                wait();
                 Console.WriteLine("2. You will have choices.");
                speech.Speak("2. You will have choices.");
                wait();
                 Console.WriteLine("3. You need to make choice.");
                speech.Speak("3. You need to make choice.");
                wait();
                 Console.WriteLine("4. Result will be shown.");
                speech.Speak("4. Result will be shown.");
                wait();
                 Console.WriteLine("Press any key to begin...");
                speech.Speak("Press any key to begin...");
                 Console.ReadKey();
                correct = 1;

            } while (correct == 0);
             correct = 0;

             //Character Name:
             do
             {
                 Console.Clear();
                wait();
                 Console.WriteLine("Please give name:");
                speech.Speak("Please give name:");
                 Player_Name = Console.ReadLine();
                { correct = 1; }
             } while (correct == 0);
             correct = 0;

             //Character Creation:
             do
             {
                 Console.Clear();
                wait();
                 Console.WriteLine("Please choose a gender as below:");
                speech.Speak("Please choose a gender as below");
                wait();
                 Console.WriteLine("Male / Female");
                speech.Speak("Male or Female");
                Player_Gender = Console.ReadLine().ToUpper();
                 if (Player_Gender == "MALE")
                 {
                    wait();
                     Console.WriteLine("You are Male.");
                    speech.Speak("You are Male.");
                    wait();
                     Console.WriteLine("Press any key to Continue...");
                    speech.Speak("Press any key to Continue...");
                     Console.ReadKey();
                    correct = 1;
                }
                 else if (Player_Gender == "FEMALE")
                 {
                    wait();
                     Console.WriteLine("You are little squeaker.");
                    speech.Speak("You are little squeaker.");
                    wait();
                     Player_Gender = "little squeaker";
                    wait();
                     Console.WriteLine("Press any key to Continue...");
                    speech.Speak("Press any key to Continue...");
                     Console.ReadKey();
                    correct = 1;
                }
                 else { }
             } while (correct == 0);
             correct = 0;

             Console.Clear();
            wait();
             Console.WriteLine("Your Full Character Description is:");
            speech.Speak("Your Full Character Description is:");
            wait();
            string message = string.Format(Answer, Player_Name, Player_Gender);
             Console.WriteLine("{0} the {1} ruski player. ", Player_Name, Player_Gender);
            speech.Speak(message);
            wait();
             Console.WriteLine("Press any key to Continue...");
            speech.Speak("Press any key to Continue...");
             Console.ReadKey();
            

            do
             {
                 correct = 0;
                 Console.Clear();
                wait();
                 Console.WriteLine("You are in RuskiLand, You see some ruski people what do you do?");
                speech.Speak("You are in RuskiLand, You see some ruski people what do you do?");
                wait();
                 Console.WriteLine("________________________________________________________________________________");
                wait();
                 Console.WriteLine("'csgo' Say Cyka blyat csgo.");
                speech.Speak("'csgo' Say Cyka blyat csgo.");
                wait();
                 Console.WriteLine("'vodka' Ask if they have vodka.");
                speech.Speak("'vodka' Ask if they have vodka.");
                wait();
                 Console.WriteLine("'best' Who is best guy on earth.");
                speech.Speak("'best' Who is best guy on earth.");
                 Input = Console.ReadLine().ToUpper();
                 if (Input == "CSGO")
                 {
                     do
                     {
                        wait();
                         Console.WriteLine("They want to play CSGO so you accept.");
                        speech.Speak("They want to play CSGO so you accept.");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    } while (correct == 0);
                 }
                 if (Input == "VODKA")
                 {
                     do
                     {
                        wait();
                         Console.WriteLine("They have Vodka so you play CSGO with them and drink Vodka.");
                        speech.Speak("They have Vodka so you play CSGO with them and drink Vodka.");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    } while (correct == 0);
                 }
                 if (Input == "BEST")
                 {
                     do
                     {
                        wait();
                         Console.WriteLine("Putin is best, Now play CSGO And Drink Some Vodka");
                        speech.Speak("Putin is best, Now play CSGO And Drink Some Vodka");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    } while (correct == 0);


                 }

                 do
                 {
                     Console.Clear();
                    wait();
                     Console.WriteLine("You play Dust 2 Which side do you rush");
                    speech.Speak("You play Dust 2 Which side do you rush");
                    wait();
                     Console.WriteLine("________________________________________________________________________________");
                    wait();
                     Console.WriteLine("'B' Rash B Blyat.");
                    speech.Speak("'B' Rash B Blyat.");
                    wait();
                     Console.WriteLine("'A' Rash A... I mean B Blyat.");
                    speech.Speak("'A' Rash A... I mean B Blyat.");
                     Input = Console.ReadLine().ToUpper();
                     if (Input == "B" || Input == "A")
                     {
                         do
                         {
                            wait();
                             Console.WriteLine("You Rash B Plant Bomb and Win Izi 16-0.");
                            speech.Speak("You Rash B Plant Bomb and Win Izi 16 to 0");
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                     }


                 } while (correct == 0);


                 do
                 {
                     Console.Clear();
                    wait();
                     Console.WriteLine("You are 4 premade and you meet really good player, What you do");
                    speech.Speak("You are 4 premade and you meet really good player, What you do");
                    wait();
                     Console.WriteLine("________________________________________________________________________________");
                    wait();
                     Console.WriteLine("'kick' You kick him with your premades.");
                    speech.Speak("'kick' You kick him with your premades.");
                    wait();
                     Console.WriteLine("'play' You play on, He calls you noob so you kick him.");
                    speech.Speak("'play' You play on, He calls you noob so you kick him.");
                    wait();
                     Console.WriteLine("'kill' You kill him, You got a 7 day ban and you decide to play on smurf.");
                    speech.Speak("'kill' You kill him, You got a 7 day ban and you decide to play on smurf.");

                     Input = Console.ReadLine().ToUpper();
                     if (Input == "KICK")
                     {
                         do
                         {
                            wait();
                             Console.WriteLine("You kick him directly and Win Izi 16-0.");
                            speech.Speak("You kick him directly and Win Izi 16 - 0.");
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                     }
                     if (Input == "PLAY")
                     {
                         do
                         {
                            wait();
                             Console.WriteLine("You kick him after a few rounds and Win  16-12.");
                            speech.Speak("You kick him after a few rounds and Win  16-12.");
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                     }
                     if (Input == "KILL")
                     {
                         do
                         {
                            wait();
                             Console.WriteLine("You play on smurf and get vacced, Now you stop play CSGO.");
                            speech.Speak("You play on smurf and get vacced, Now you stop play CSGO.");
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1; 
                         } while (correct == 0);
                     }


                 } while (correct == 0);
             } while (correct == 0);

             do
             {
                 Console.Clear();
                wait();
                 Console.WriteLine("This was your Ruski adventure, Now you are real Ruski.");
                speech.Speak("This was your Ruski adventure, Now you are real Ruski.");
                wait();
                 Console.WriteLine("Press any key to Continue...");
                speech.Speak("Press any key to Continue...");
                 Console.ReadKey();
                correct = 1;
            } while (correct == 0);

            League();
         }  
        static public void League()
        {
			
            //int
            int correct = 0;

            //Strings:
            string Sum_Name;
            string Input;
            string Region_State;
            string vodka;
            string Answer = "{0} from the {1} server. ";
            SpeechSynthesizer speech = new SpeechSynthesizer();


            do
            {
                 Console.Clear();
                wait();
                 Console.WriteLine("Welcome to the toxic league community.\n");
                speech.Speak("Welcome to the toxic league community.");
                wait();
                 Console.WriteLine("In this game we will give you toxic options.");
                speech.Speak("In this game we will give you toxic options.");
                wait();
                 Console.WriteLine("Every situation will have same pattern.");
                speech.Speak("Every situation will have same pattern.");
                wait();
                 Console.WriteLine("1. Situation will be presented.");
                speech.Speak("1. Situation will be presented.");
                wait();
                 Console.WriteLine("2. You will have choices.");
                speech.Speak("2. You will have choices.");
                wait();
                 Console.WriteLine("3. You need to make choice.");
                speech.Speak("3. You need to make choice.");
                wait();
                 Console.WriteLine("4. Result will be shown.");
                speech.Speak("4. Result will be shown.");
                wait();
                 Console.WriteLine("Press any key to start.");
                speech.Speak("Press any key to start");
                 Console.ReadKey();
                correct = 1;

            } while (correct == 0);
            correct = 0;

            //Character Name:
            do
            {
                 Console.Clear();
                wait();
                 Console.WriteLine("Please enter summonername:");
                speech.Speak("Please enter summonername:");
                Sum_Name = Console.ReadLine().ToUpper();
                if (Sum_Name == "")
                {
                    wait();
                     Console.WriteLine("Enter a fucking summonername!!");
                    speech.Speak("Enter a fucking summonername!!");

                }
                else
                {
                    wait();
                     Console.WriteLine("Did you choose this summonername?: ToxicMofo\n");
                    speech.Speak("Did you choose this summonername?: ToxicMofo\n");
                    wait();
                     Console.WriteLine("Yes | No");
                    speech.Speak("Yes or No");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "YES")
                    {
                        wait();
                         Console.WriteLine("You chose the summonername: ToxicMofo");
                        speech.Speak("You chose the summonername: ToxicMofo");
                        Sum_Name = "ToxicMofo";
                        wait();
                         Console.WriteLine("Lets go and have some bad teams");
                        speech.Speak("Lets go and have some bad teams");
                        wait();
                         Console.WriteLine("Have Fun!!");
                        speech.Speak("Have Fun!!");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;

                    }
                    else if (Input == "NO")
                    {
                        wait();
                         Console.WriteLine("Your new summoner name is: Salty-Toxic-Mofo");
                        speech.Speak("Your new summoner name is: Salty Toxic Mofo");
                        Sum_Name = "Salty-Toxic-Mofo";
                        wait();
                         Console.WriteLine("Lets go and have some bad teams");
                        speech.Speak("Lets go and have some bad teams");
                        wait();
                         Console.WriteLine("Have Fun!!");
                        speech.Speak("Have Fun!!");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    }

                }
            } while (correct == 0);
            correct = 0;

            //Character Region:
            do
            {
                 Console.Clear();
                wait();
                 Console.WriteLine("Please choose a Summoner Region:");
                speech.Speak("Please choose a Summoner Region:");
                wait();
                 Console.WriteLine("EUW / NA / KR / RU");
                speech.Speak("Western Europe or North america or Korea or Russia");
                Region_State = Console.ReadLine().ToUpper();
                if (Region_State == "EUW")
                {
                    wait();
                     Console.WriteLine("You get placed in the Western Europe");
                    speech.Speak("You get placed in the Western Europe");
                    wait();
                     Console.WriteLine("This is the most Salty place, Good for you");
                    speech.Speak("This is the most Salty place, Good for you");
                    wait();
                    Region_State = "Western European";
                     Console.WriteLine("Press any key to Continue...");
                    speech.Speak("Press any key to Continue...");
                     Console.ReadKey();
                    correct = 1;
                }
                else if (Region_State == "NA")
                {
                    wait();
                     Console.WriteLine("You are placed in North America");
                    speech.Speak("You are placed in North America");
                    wait();
                     Console.WriteLine("Here are people the worst, you will become challenjour Eazy");
                    speech.Speak("Here are people the worst, you will become challenjour Eazy");
                    wait();
                    Region_State = "North American";
                     Console.WriteLine("Press any key to Continue...");
                    speech.Speak("Press any key to Continue...");
                     Console.ReadKey();
                    correct = 1;
                }
                else if (Region_State == "KR")
                {
                    wait();
                     Console.WriteLine("You are placed in Korea");
                    speech.Speak("You are placed in Korea");
                    wait();
                     Console.WriteLine("You probably wont get higher than Bronze V");
                    speech.Speak("You probably wont get higher than Bronze 5");
                    wait();
                    Region_State = "Korean";
                     Console.WriteLine("Press any key to Continue...");
                    speech.Speak("Press any key to Continue...");
                     Console.ReadKey();
                    correct = 1;
                }
                else if (Region_State == "RU")
                {
                    wait();
                     Console.WriteLine("You are placed in Russia");
                    speech.Speak("You are placed in Russia");
                    wait();
                     Console.WriteLine("Do you have vodka: Yes/No");
                    speech.Speak("Do you have vodka: Yes or No");
                    vodka = Console.ReadLine().ToUpper();
                    if (vodka == "YES")
                    {
                        wait();
                         Console.WriteLine("You are real russian, You are accepted");
                        speech.Speak("You are real russian, You are accepted");
                        wait();
                        Region_State = "Russian";
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    }
                    else if (vodka == "NO")
                    {
                        wait();
                         Console.WriteLine("You are not accepted as Russian, You get placed in EUW");
                        speech.Speak("You are not accepted as Russian, You get placed in Western Europe");
                        wait();
                        Region_State = "Western European";
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    }
                    wait();
                     Console.WriteLine("Press any key to Continue...");
                    speech.Speak("Press any key to Continue...");
                     Console.ReadKey();
                }
                else { }
            } while (correct == 0);
            correct = 0;

             Console.Clear();
            wait();
             Console.WriteLine("Your Full Character Description, is:");
            speech.Speak("Your Full Character Description, is:");
            wait();
            string message = string.Format(Answer, Sum_Name, Region_State);
             Console.WriteLine("{0} from the {1} server. ", Sum_Name, Region_State);
            speech.Speak(message);
            wait();
             Console.WriteLine("Press any key to Continue...");
            speech.Speak("Press any key to Continue...");
             Console.ReadKey();

            do
            {
                 Console.Clear();
                wait();
                 Console.WriteLine("You are in champ select and someone stole your jungle, What do you do?");
                speech.Speak("You are in champ select and someone stole your jungle, What do you do?");
                wait();
                 Console.WriteLine("________________________________________________________________________________");
                wait();
                 Console.WriteLine("'lock'Just lock in your jungle and double jungle.");
                speech.Speak("'lock'Just lock in your jungle and double jungle.");
                wait();
                 Console.WriteLine("'else'Pick something else and just play normally.");
                speech.Speak("'else'Pick something else and just play normally.");
                wait();
                 Console.WriteLine("'flame'Pick something else and flame the sh*t out of him.");
                speech.Speak("'flame'Pick something else and flame the shit out of him.");
                Input = Console.ReadLine().ToUpper();
                if (Input == "LOCK")
                {
                    do
                    {
                        wait();
                         Console.WriteLine("You mostly counter-jungle and the enemy jungler quits. You win");
                        speech.Speak("You mostly counter jungle and the enemy jungler quits. You win");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1; 
                    } while (correct == 0);
                }
                if (Input == "ELSE")
                {
                    do
                    {
                        wait();
                         Console.WriteLine("You pick something else. He sucks alot in jungle and you lose becuese he couldn't smite baron");
                        speech.Speak("You pick something else. He sucks alot in jungle and you lose becuese he couldn't smite baron");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    } while (correct == 0);
                }
                if (Input == "FLAME")
                {
                    do
                    {
                        wait();
                         Console.WriteLine("You pick something else but flame the shit out of him, They report you and you get a chat restriction");
                        speech.Speak("You pick something else but flame the shit out of him, They report you and you get a chat restriction");
                        wait();
                         Console.WriteLine("Press any key to Continue...");
                        speech.Speak("Press any key to Continue...");
                         Console.ReadKey();
                        correct = 1;
                    } while (correct == 0);


                }

                do
                {
                     Console.Clear();
                    wait();
                     Console.WriteLine("You are toplane. You are last pick and see the enemy picks vladimir top, What do you do?");
                    speech.Speak("You are toplane. You are last pick and see the enemy picks vladimir top, What do you do?");
                    wait();
                     Console.WriteLine("________________________________________________________________________________");
                    wait();
                     Console.WriteLine("'Best' Just pick your best pick");
                    speech.Speak("'Best' Just pick your best pick");
                    wait();
                     Console.WriteLine("'Counter' Go to lolcounter.com and pick the best counter into him");
                    speech.Speak("'Counter' Go to lolcounter.com and pick the best counter into him");
                    wait();
                     Console.WriteLine("'Quit' You quit champ select");
                    speech.Speak("'Quit' You quit champ select");
                    Input = Console.ReadLine().ToUpper();
                    if (Input == "BEST")
                    {
                        do
                        {
                            wait();
                             Console.WriteLine("You pick your best champ, you win early game but he stomps you late game. He was Challenjer and main vladimir");
                            speech.Speak("You pick your best champ, you win early game but he stomps you lategame. He was Challenjer and main vladimir");
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                    }
                    if (Input == "COUNTER")
                    {
                        do
                        {
                            wait();
                             Console.WriteLine("He is Challenjer and main vladimir. He knows how to play against hes counter. You get stomped");
                            speech.Speak("He is challenjer and main vladimir. He knows how to play against hes counter. You get stomped");
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                    }
                    if (Input == "QUIT")
                    {
                        do
                        {
                            wait();
                             Console.WriteLine("You decide to quit the game and look up hes sum name. He was Challenjer and main vladimir. Good you quit.");
                            speech.Speak("You decide to quit the game and look up hes summoner name. he was challenjer and main vladimir. Good you quit.");
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                    }

                } while (correct == 0);


                do
                {
                    //array Items League
                    string[] item = new string[4];
                    item[0] = "You get a thornmail. this item does magical damage to champions that basic attack you";
                    item[1] = "You get a Blood Thirster";
                    item[2] = "You get a Blade Of The Ruined King";
                    item[3] = "You get a RageBlade";
                     Console.Clear();
                    wait();
                     Console.WriteLine("You play against a full ad team, you play Xin Zhao and you get into the late game. What do you build?");
                    speech.Speak("You play against a full ad team, you play Xin Zhao and you get into the late game. What do you build?");
                    wait();
                     Console.WriteLine("________________________________________________________________________________");
                    wait();
                     Console.WriteLine("'1' Thornmail.");
                    speech.Speak("'1' Thornmail.");
                    wait();
                     Console.WriteLine("'2' Blood Thirster.");
                    speech.Speak("'2' Blood Thirster.");
                    wait();
                     Console.WriteLine("'3' Botrk.");
                    speech.Speak("'3' Blade of the ruined king.");
                    wait();
                     Console.WriteLine("'4' RageBlade.");
                    speech.Speak("'4' RageBlade.");
                    wait();
                     Console.WriteLine("'5' Item Descriptions.");
                    speech.Speak("'5' Item Descriptions.");


                    string i_Input = Console.ReadLine() ;
                    if (i_Input == "1")
                    {
                        do
                        {
                            wait();
                             Console.WriteLine("{0}.", item[0]);
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                    }
                    if (i_Input == "2")
                    {
                        do
                        {
                            wait();
                             Console.WriteLine("{0}.", item[1]);
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                    }
                    if (i_Input == "3")
                    {
                        do
                        {
                            wait();
                             Console.WriteLine("{0}.", item[2]);
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                    }
                    if (i_Input == "4")
                    {
                        do
                        {
                            wait();
                             Console.WriteLine("{0}.", item[3]);
                            wait();
                             Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                             Console.ReadKey();
                            correct = 1;
                        } while (correct == 0);
                    }
                    if (i_Input == "5")
                    { 
                        description();
                        correct = 0;
                    }

                } while (correct == 0);
            } while (correct == 0);

            do
            {
                wait();
                 Console.WriteLine("You became too toxic and decide to stop playing league. GL with your real life");
                wait();
                 Console.WriteLine("Press any key to Continue...");
                speech.Speak("Press any key to Continue...");
                 Console.ReadKey();
                correct = 1;
            } while (correct == 0);
        }
        //Nog aan werken   
        static public void Battlefield()
        {
            string input;
            int classes = 0;
            SpeechSynthesizer speech = new SpeechSynthesizer();
            do
            {

                do
                {
                    Console.Clear();
                    wait();
                    Console.WriteLine("Good day Soldiers today we came into an epic battle,\n You need to choose the best options to even make it alive around here. Good luck soldier.");
                    speech.Speak("Good day soldiers today we came into an epic battle, You need to choose the best options to even make it alive around here. Good luck soldier.");
                    wait();
                    Console.WriteLine("In this epic journy you have to do the following:");
                    speech.Speak("In this epic journy you have to do the following:");
                    wait();
                    Console.WriteLine("1. You read where you got yourself in to.");
                    speech.Speak("1. You read where you got yourself in to.");
                    wait();
                    Console.WriteLine("2. You will get some options to choose from.");
                    speech.Speak("2. You will get some options to choose from.");
                    wait();
                    Console.WriteLine("3. You need to choose 1 option.");
                    speech.Speak("3. You need to choose 1 option.");
                    wait();
                    Console.WriteLine("4. Your result will be shown, Choose wisely. 1 of the options is Deadly.");
                    speech.Speak("4. Your result will be shown, Choose wisely. 1 of the options is Deadly.");
                    wait();
                    Console.WriteLine("Press any key to begin soldier...");
                    speech.Speak("Press any key to begin soldier...");
                    Console.ReadKey();
                    correct = 1;
                } while (correct == 0);
                correct = 0;


                //char name
                do
                {
                    Console.Clear();
                    wait();
                    Console.WriteLine("Enter a name soldier!");
                    speech.Speak("Enter a name soldier!");
                    string s_Name = Console.ReadLine();
                    if (s_Name == "")
                    {
                        wait();
                        Console.WriteLine("Enter a Fucking name Soldier!!!!");
                        speech.Speak("Enter a Fucking name Soldier!!!!");
                        correct = 0;
                    }
                    else
                    {
                        correct = 1;
                    }
                    
                } while (correct == 0);
                correct = 0;

                //char class
                do
                {
                    Console.Clear();
                    wait();
                    Console.WriteLine("Choose a class to see what it offers:");
                    speech.Speak("Choose a class to see what it offers:");
                    Console.WriteLine("1. Assault");
                    speech.Speak("1. Assault");
                    Console.WriteLine("2. Medic");
                    speech.Speak("2. Medic");
                    Console.WriteLine("3. Scout");
                    speech.Speak("3. Scout");
                    string s_class = "";
                    s_class = Console.ReadLine();
                    if (s_class == "1")
                    {
                        Assault();
                        classes = 1;
                        
                    }
                    if (s_class == "2")
                    {
                        Medic();
                        classes = 2;
                        
                    }
                    if (s_class == "3")
                    {
                        Scout();
                        classes = 3;
                        
                    }


                } while (correct == 0);

                do
                {
                    Console.Clear();
                    Console.WriteLine("You are trying to ambush a gun truck, How do you take it out.");
                    speech.Speak("You are trying to ambush a gun truck, How do you take it out.");
                    Console.WriteLine("_____________________________________________________________");
                    if (classes == 1)
                    {
                        Console.WriteLine("1.You got some mines, You should lay them down.");
                        speech.Speak("1.You got some mines, You should lay them down.");
                        Console.WriteLine("2.You have an RPG. Maybe shoot???");
                        speech.Speak("2.You have an RPG. Maybe shoot???");
                        Console.WriteLine("3.Just go in.");
                        speech.Speak("3.Just go in.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("The all blow up into little pieces, Goodjob soldier!");
                            speech.Speak("The all blow up into little pieces, Goodjob soldier!");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 5;
                        }
                        if (input == "2")
                        {
                            Console.WriteLine("You shoot them into little pieces. Good shot soldier!");
                            speech.Speak("You shoot them into little pieces. Good shot soldier!");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 5;
                        }
                        if (input == "3")
                        {
                            Console.WriteLine("You go in without thoughts and you instantly die.");
                            speech.Speak("You go in without thoughts and you instantly die.");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 4;
                        }

                    }
                    
                    if (classes == 2)
                    {
                        Console.WriteLine("1.Stay back and heal.");
                        speech.Speak("1.Stay back and heal.");
                        Console.WriteLine("2.Flank and kill.");
                        speech.Speak("2.Flank and kill.");
                        Console.WriteLine("3.Go in.");
                        speech.Speak("3.Go in.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("You heal your team so they win the fight.");
                            speech.Speak("You heal your team so they win the fight.");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 5;
                        }
                        if (input == "2")
                        {
                            Console.WriteLine("You walk into a minefield and die.");
                            speech.Speak("You walk into a minefield and die.");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 4;
                        }
                        if (input == "3")
                        {
                            Console.WriteLine("You go in without thoughts, They dont expect that and they die.");
                            speech.Speak("You go in without thoughts, They don't expect that and they die");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 5;
                        }
                    }
                    if (classes == 3)
                    {
                        Console.WriteLine("1. Sniper driver.");
                        speech.Speak("1. Sniper driver.");
                        Console.WriteLine("2. send your squad to take out the truck.");
                        speech.Speak("2. send your squad to take out the truck.");
                        Console.WriteLine("3. Get closer and place mines.");
                        speech.Speak("3. Get closer and place mines.");
                        input = Console.ReadLine();
                        if (input == "1")
                        {
                            Console.WriteLine("You have a good shot and they crash into a tree.");
                            speech.Speak("You have a good shot and they crash into a tree.");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 5;
                        }
                        if (input == "2")
                        {
                            Console.WriteLine("You send in your squad to flank them, they wipe them.");
                            speech.Speak("You send in your squad to flank them, they wipe them.");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 5;
                        }
                        if (input == "3")
                        {
                            Console.WriteLine("You explode while you try to place mines.");
                            speech.Speak("You explode while you try to place mines.");
                            Console.WriteLine("Press any key to Continue...");
                            speech.Speak("Press any key to Continue...");
                            Console.ReadKey();
                            correct = 4;
                        }

                    }
                    Console.WriteLine("");
                } while (correct == 0);
            } while (correct < 3);
            if (correct == 4)
            {
                Console.WriteLine("You have died in the mission. You will get remembered as a great soldier.\n");
                speech.Speak("You have died in the mission. You will get remembered as a great soldier.");
                Console.WriteLine("Do you wanna start over?");
                speech.Speak("Do you wanna start over?");
                Console.WriteLine("Yes/No");
                speech.Speak("Yes or No");
                string play = Console.ReadLine().ToUpper();
                if (play == "YES")
                {
                    Console.WriteLine("Alright Lets Go!");
                    speech.Speak("Alright Lets Go!");
                    Console.WriteLine("Press any key to Continue...");
                    speech.Speak("Press any key to Continue...");
                    Console.ReadKey();
                    Battlefield();
                }
                if (play == "NO")
                {
                    Console.WriteLine("You will be remembered as one of the hard working ones, a soldier who fought for hes country and he people.");
                    speech.Speak("You will be remembered as one of the hard working ones, a soldier who fought for hes country and he people.");
                    Console.WriteLine("Press any key to end the Text Advanture.");
                    speech.Speak("Press any key to end the Text Advanture.");
                    Console.ReadLine();
                    Mario();
                }
            }
            if (correct == 5)
            {
                Console.WriteLine("You have Didnt die in the mission. You are a  great soldier.\n");
                speech.Speak("You have Didn't die in the mission. You are a  great soldier.");
                Console.WriteLine("Do you wanna start over?");
                speech.Speak("Do you wanna start over?");
                Console.WriteLine("Yes/No");
                speech.Speak("Yes or No");
                string play = Console.ReadLine().ToUpper();
                if (play == "YES")
                {
                    Console.WriteLine("Alright Lets Go!");
                    speech.Speak("Alright Lets Go!");
                    Battlefield();
                }
                if (play == "NO")
                {
                    Console.WriteLine("Alright soldier, You great sir have won us the war.\n You fought for Freedom and Safety.\n You shall be granted a Medal of Honor for your great Service./n Thank you.");
                    speech.Speak("Alright soldier, You great sir have won us the war. You fought for Freedom and Safety. You shall be granted a Medal of Honor for your great Service. Thank you.");
                    Console.WriteLine("Press any key to end the Text Advanture.");
                    speech.Speak("Press any key to end the Text Advanture.");
                    Console.ReadLine();
                    Mario();
                }
            }
        }
		static public void Assault ()
		{
            SpeechSynthesizer speech = new SpeechSynthesizer();
            Console.Clear();
            Console.WriteLine("This is what you get in the Assault Class:");
            speech.Speak("This is what you get in the Assault Class:");
            Console.WriteLine("Primary: AR-15");
            speech.Speak("Primary: AR-15");
            Console.WriteLine("Secondary: G17");
            speech.Speak("Secondary: G17");
            Console.WriteLine("Do you Really wanna pick this class?");
            speech.Speak("Do you Really wanna pick this class?");
            Console.WriteLine("Yes/No");
            speech.Speak("Yes or No");
            string input = Console.ReadLine().ToUpper();
            if (input == "YES")
            {
                Console.WriteLine("You chose the Assault Class, Good luck Soldier.");
                speech.Speak("You chose the Assault Class, Good luck Soldier.");
                Console.WriteLine("Press any key to begin!!!");
                speech.Speak("Press any key to begin!!!");
                Console.ReadKey();
                correct = 2;
            }
            if (input == "NO")
            {
                Console.WriteLine("Press Any key to go back...");
                speech.Speak("Press Any key to go back...");
                Console.ReadKey();
            }
        }
		static public void Medic ()
		{
            SpeechSynthesizer speech = new SpeechSynthesizer();
            Console.Clear();
            Console.WriteLine("This is what you get in the Medic Class:");
            speech.Speak("This is what you get in the Medic Class:");
            Console.WriteLine("Primary: m4 carbine");
            speech.Speak("Primary: m4 carbine");
            Console.WriteLine("Secondary: G17");
            speech.Speak("Secondary: G17");
            Console.WriteLine("Do you Really wanna pick this class?");
            speech.Speak("Do you Really wanna pick this class?");
            Console.WriteLine("Yes/No");
            speech.Speak("Yes or No");
            string input = Console.ReadLine().ToUpper();
            if (input == "YES")
            {
                Console.WriteLine("You chose the Medic Class, Good luck Soldier.");
                speech.Speak("You chose the Medic Class, Good luck Soldier.");
                Console.WriteLine("Press any key to begin!!!");
                speech.Speak("Press any key to begin!!!");
                Console.ReadKey();
                correct = 2;
            }
            if (input == "NO")
            {
                Console.WriteLine("Press Any key to go back...");
                speech.Speak("Press Any key to go back...");
                Console.ReadKey();
            }
        }
		static public void Scout ()
		{
            SpeechSynthesizer speech = new SpeechSynthesizer();
            Console.Clear();
            Console.WriteLine("This is what you get in the Scout class:");
            speech.Speak("This is what you get in the Scout class:");
            Console.WriteLine("Primary: GM6 Lynx");
            speech.Speak("Primary: GM6 Lynx");
            Console.WriteLine("Secondary: G17");
            speech.Speak("Secondary: G17");
            Console.WriteLine("Do you Really wanna pick this class?");
            speech.Speak("Do you Really wanna pick this class?");
            Console.WriteLine("Yes/No");
            speech.Speak("Yes or No");
            string input = Console.ReadLine().ToUpper();
            if (input == "YES")
            {
                Console.WriteLine("You chose the Scout Class, Good luck Soldier.");
                speech.Speak("You chose the Scout Class, Good luck Soldier.");
                Console.WriteLine("Press any key to begin!!!");
                speech.Speak("Press any key to begin!!!");
                Console.ReadKey();
                correct = 2;
            }
            if (input == "NO")
            {
                Console.WriteLine("Press Any key to go back...");
                speech.Speak("Press Any key to go back...");
                Console.ReadKey();
            }
		}
        static public void wait()
        {
            Thread.Sleep(250);
        }
        static public void description()
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            Console.Clear();
            Console.WriteLine("These are the descriptions of all the League items:");
            speech.Speak("These are the descriptions of all the league items:");
            wait();
            Console.WriteLine("Thornmail:Damage is reflected when hit by a basic attack, regardless of whether the attack deals damage.\n If the attacker is Blind icon blinded, or the wearer is protected by a shield or invulnerability, damage will still be reflected./n By itself, Thornmail item.png Thornmail reflects at least 25 magic damage on being hit.");
            speech.Speak("Thornmail: Damage is reflected when hit by a basic attack, regardless of whether the attack deals damage. If the attacker is Blind icon blinded, or the wearer is protected by a shield or invulnerability, damage will still be reflected. By itself, Thornmail item.png Thornmail reflects at least 25 magic damage on being hit.");
            wait();
            Console.WriteLine("Bloodthirster:Your life steal overheals you, converting the excess healing into a shield that absorbs up to 50 - 350 (based on level)\n damage and decays when out of combat for 25 seconds.");
            speech.Speak("Bloodthirster:Your life steal overheals you, converting the excess healing into a shield that absorbs up to 50 - 350 (based on level) damage and decays when out of combat for 25 seconds.");
            wait();
            Console.WriteLine("Blade of the Ruined king (Botrk):Basic attacks deal 6% of the target's current health (min 10) in bonus on-hit physical damage (max 60 vs. minions and monsters).");
            speech.Speak("Blade of the ruined king:Basic attacks deal 6% of the target's current health (min 10) in bonus on-hit physical damage (max 60 vs. minions and monsters).");
            wait();
            Console.WriteLine("RageBlade:Basic attacks grant +8% attack speed, +3 attack damage and +4 ability power for 5 seconds, stacking up to 6 times,\n granting a total of +48% attack speed, +18 attack damage and +24 ability power. At 6 stacks, gain GUINSOO'S RAGE.");
            speech.Speak("Rageblade:Basic attacks grant +8% attack speed, +3 attack damage and +4 ability power for 5 seconds, stacking up to 6 times, granting a total of +48% attack speed, +18 attack damage and +24 ability power. At 6 stacks, gain GUINSOO'S RAGE.");
            wait();
            Console.WriteLine("Press any key to go back...");
            speech.Speak("Press any key go back...");
            Console.ReadKey();
        }
        static public void Mario ()
		{
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(523, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(392, 125);
            Thread.Sleep(375);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(250);
            Console.Beep(392, 125);
            Thread.Sleep(250);
            Console.Beep(330, 125);
            Thread.Sleep(250);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(494, 125);
            Thread.Sleep(125);
            Console.Beep(466, 125);
            Thread.Sleep(42);
            Console.Beep(440, 125);
            Thread.Sleep(125);
            Console.Beep(392, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(880, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(784, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(587, 125);
            Console.Beep(494, 125);
            Thread.Sleep(375);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(625);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(600);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(698, 125);
            Console.Beep(698, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Console.Beep(740, 125);
            Console.Beep(698, 125);
            Thread.Sleep(42);
            Console.Beep(622, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(415, 125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Thread.Sleep(125);
            Console.Beep(440, 125);
            Console.Beep(523, 125);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(622, 125);
            Thread.Sleep(250);
            Console.Beep(587, 125);
            Thread.Sleep(250);
            Console.Beep(523, 125);
            Thread.Sleep(625);
            //
            Console.Beep(658, 125);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(1320, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 250);
            Console.Beep(1320, 125);
            Console.Beep(1188, 125);
            Console.Beep(1056, 250);
            Console.Beep(990, 250);
            Console.Beep(880, 500);
            Console.Beep(880, 250);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 750);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(250);
            Console.Beep(1188, 500);
            Console.Beep(1408, 250);
            Console.Beep(1760, 500);
            Console.Beep(1584, 250);
            Console.Beep(1408, 250);
            Console.Beep(1320, 750);
            Console.Beep(1056, 250);
            Console.Beep(1320, 500);
            Console.Beep(1188, 250);
            Console.Beep(1056, 250);
            Console.Beep(990, 500);
            Console.Beep(990, 250);
            Console.Beep(1056, 250);
            Console.Beep(1188, 500);
            Console.Beep(1320, 500);
            Console.Beep(1056, 500);
            Console.Beep(880, 500);
            Console.Beep(880, 500);
            Thread.Sleep(500);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 1000);
            Console.Beep(440, 1000);
            Console.Beep(419, 1000);
            Console.Beep(495, 1000);
            Console.Beep(660, 1000);
            Console.Beep(528, 1000);
            Console.Beep(594, 1000);
            Console.Beep(495, 1000);
            Console.Beep(528, 500);
            Console.Beep(660, 500);
            Console.Beep(880, 1000);
            Console.Beep(838, 2000);
            //
        }
    }

}
    