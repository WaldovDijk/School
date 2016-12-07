using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class thirdlesson : AbstractGame
    {
        private int vierkant;
        private bool pluskey;
        private bool minkey;
        private int count;
        int xPositie;
        int yPositie;
        bool linksGeklikt;
        bool rechtsGeklikt;
        bool spacebar = true;
        public Random randomGeneratorx = new Random();
        public Random randomGenerator = new Random(5);
        public int[] getalc = new int[15];
        public int[] getalc1 = new int[15];
        public int[] getalc2 = new int[15];
        public int[] getallenx = new int[15];
        public int[] getallenx1 = new int[15];
        public int[] getalleny = new int[15];
        public int[] getalleny1 = new int[15];
        int aantal;
        public int random1 = 0;
        List<int> posxlist = new List<int>();
        List<int> posylist = new List<int>();
        public override void GameStart()
        {

        }

        public override void GameEnd()
        {
        }

        public override void Update()
        {
            pluskey = GAME_ENGINE.GetKeyDown(Key.Add);
            minkey = GAME_ENGINE.GetKeyDown(Key.Subtract);

            if (pluskey == true)
            {
                pluskey = false;
                count += 1;
            }
            if (minkey == true)
            {
                minkey = false;
                count -= 1;
            }

            if (count == 5)
            {
                count -= 1;
            }
            if (count == (-1))
            {
                count += 1;
            }
            if (spacebar == true)
            {
                Console.Clear();
                random1 = randomGenerator.Next(1, 15);
                aantal = 0;
                while ((aantal != random1))
                {
                    getallenx1[aantal] = randomGeneratorx.Next(390, 470);
                    getalleny1[aantal] = randomGeneratorx.Next(60, 180);
                    getallenx[aantal] = randomGeneratorx.Next((-70), 130);
                    getalleny[aantal] = randomGeneratorx.Next((-40), 40);
                    getalc[aantal] = randomGeneratorx.Next(0, 255);
                    getalc1[aantal] = randomGeneratorx.Next(0, 255);
                    getalc2[aantal] = randomGeneratorx.Next(0, 255);
                    Console.WriteLine("vierkant :" + (aantal + 1));
                    Console.WriteLine("X " + getallenx[aantal] + " Y " + getalleny[aantal]);
                    Console.WriteLine("X1 " + getallenx1[aantal] + " Y1 " + getalleny1[aantal]);
                    Console.WriteLine("RGB waarden " + getalc[aantal] + ", " + getalc1[aantal] + ", " + getalc2[aantal]);
                    Console.WriteLine("");
                    aantal++;
                }
                spacebar = false;
                aantal = 0;
            }
            spacebar = GAME_ENGINE.GetKeyDown(Key.Back);

            Vector2 muisPositie = GAME_ENGINE.GetMousePosition();

            xPositie = muisPositie.X;
            yPositie = muisPositie.Y;

            linksGeklikt = GAME_ENGINE.GetMouseButtonDown(0);
            rechtsGeklikt = GAME_ENGINE.GetMouseButtonDown(1);

            if (linksGeklikt == true)
            {
                linksGeklikt = false;
                posxlist.Add(xPositie);
                posylist.Add(yPositie);
            }

            if (rechtsGeklikt == true)
            {
                linksGeklikt = false;
                posxlist.Clear();
                posylist.Clear();
            }


        }
        public override void Paint()
        {
            //name
            GAME_ENGINE.DrawString("Waldo van Dijk", 10, 10, 500, 10);
            GAME_ENGINE.DrawString("klas : 1GD1", 10, 25, 500, 10);

            //paar vierkanten.
            GAME_ENGINE.DrawString("1.", 10, 60, 500, 10);

            for (vierkant = 0; vierkant <= 5; vierkant++)
            {
                GAME_ENGINE.DrawRectangle(50 + (vierkant * 10), 50 + (vierkant * 10), 150 - (vierkant * 20), 150 - (vierkant * 20));
            }

            //spiraal.
            GAME_ENGINE.DrawString("2.", 10, 250, 500, 10);

            for (int plus = 0; plus <= count; plus++)
            {
                GAME_ENGINE.DrawLine(15 + (plus * 15), 250 + (plus * 15), 200 - (plus * 15), 250 + (plus * 15));
                GAME_ENGINE.DrawLine(200 - (plus * 15), 250 + (plus * 15), 200 - (plus * 15), 420 - (plus * 15));
                GAME_ENGINE.DrawLine(200 - (plus * 15), 420 - (plus * 15), 30 + (plus * 15), 420 - (plus * 15));
                GAME_ENGINE.DrawLine(30 + (plus * 15), 420 - (plus * 15), 30 + (plus * 15), 265 + (plus * 15));

            }

            //RandomDraw.
            GAME_ENGINE.DrawString("3.", 300, 10, 200, 10);
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillRectangle(320, 20, 300, 200);
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.DrawRectangle(320, 20, 300, 200);
            aantal = 0;
            while (aantal != random1)
            {

                GAME_ENGINE.SetColor(getalc[aantal], getalc1[aantal], getalc2[aantal]);
                GAME_ENGINE.FillRectangle(getallenx1[aantal], getalleny1[aantal], getallenx[aantal], getalleny[aantal]);
                aantal++;
            }
            GAME_ENGINE.SetColor(0, 0, 0);

            //Dot-Lines.
            GAME_ENGINE.DrawString("4.", 400, 300, 500, 10);
            GAME_ENGINE.DrawEllipse(xPositie, yPositie, 10, 10);

            for (int total = 0; total < posylist.Count; total++)
            {
                GAME_ENGINE.SetColor(20, 20, 200);
                GAME_ENGINE.FillEllipse(posxlist[total], posylist[total], 10, 10);
                GAME_ENGINE.SetColor(0, 0, 0);
                if (total != 0)
                {
                    GAME_ENGINE.DrawLine(posxlist[(total - 1)], posylist[(total - 1)], posxlist[(total)], posylist[(total)]);
                }

            }
        }
    }
}