using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class League : AbstractGame
    {
        private int x = 0;
        private int y = 500;
        // private int Speedx = 0;
        //private int Speedy = 0;
        private int xPositie;
        private int yPositie;
        private int score = 0;
        private bool linksGeklikt;
        private bool rechtsGeklikt;
        private bool blokje = true;
        private Bitmap ball = null;
        public Random randomGenerator = new Random();
        public override void GameStart()
        {
            ball = new Bitmap("Fireball.png");
            x = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 40;
            x = x * 40;
            //Everything that has to happen when the game starts happens here.
            //F.e. initializing objects.
        }

        public override void GameEnd()
        {
            //Clean up unmanaged objects here (F.e. bitmaps & fonts)

            //For example:
            //m_Bitmap.Dispose();
            //m_Font.Dispose();
        }

        public override void Update()
        {
            if (x >= 250)
            {
                y -= 3;
                x += 3;
            }
            if (x <= 250)
            {
                y -= 3;
                x -= 3;
            }
            if ((x == 500 && x >= 500 )||(y == 0 && x <= 0))
            {
                score -= 100;
                blokje = false;
                x = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 40;
                x = x * 40;
                y = 500;
                blokje = true;
            }

            Vector2 muisPositie = GAME_ENGINE.GetMousePosition();

            xPositie = muisPositie.X;
            yPositie = muisPositie.Y;

            linksGeklikt = GAME_ENGINE.GetMouseButtonDown(0);
            rechtsGeklikt = GAME_ENGINE.GetMouseButtonDown(1);



            if (linksGeklikt == true)
            {
                if ((xPositie >= x && xPositie <= x + 41) && (yPositie >= y && yPositie <= y + 41))
                {
                    score += 100;
                    blokje = false;
                    x = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 40;
                    x = x * 40;
                    y = 500;
                    blokje = true;

                }
                linksGeklikt = false;
            }
        }


        public override void Paint()
        {

            GAME_ENGINE.DrawString("Score: " + score + ".", 230, 0, 2000, 200);
            if (blokje == true)
            {
                GAME_ENGINE.DrawBitmap(ball, x, y, 0, 0, 40, 40);
            }

            GAME_ENGINE.DrawEllipse(xPositie, yPositie,10, 10);



        }
    }
}
