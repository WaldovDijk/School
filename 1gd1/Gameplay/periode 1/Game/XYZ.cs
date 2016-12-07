using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class opdracht6 : AbstractGame
    {
        //int's
        private int slow = 0;
        private int move = 0;
        private int currentPosX = 640/2;
        private int currentPosY = 640/2+64;
        private int currentPosX2 = 640 / 2;
        private int currentPosY2 = 640 / 2;
        //private int lastPos;
        private int score = 0;
        private int pickY;
        private int pickX;
        private int pickup = 0;
        private int block;
        
        //Booleans


        //randoms
        public Random randomGenerator = new Random();
        //Strings
        //Array's
        // private Bitmap Snekbody = null;
        //Bitmaps
        private Bitmap Snek = null;
        //list
        List<int> extralengte = new List<int>();
        List<int> extrabreedte = new List<int>();

        //List<int> SnekBody = new List<int>();

        public override void GameStart()
        {
            Snek = new Bitmap("Snake_Graphics.png");
            pickY = randomGenerator.Next(0, GAME_ENGINE.GetScreenHeight())/64;
            pickX = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth())/64;
            pickX = pickX * 64;
            pickY = pickY * 64;
            extrabreedte.Add(currentPosX2);
            extralengte.Add(currentPosY2);
        }

        public override void GameEnd()
        {

        }

        public override void Update()
        {
            //Booleans
          
            if (GAME_ENGINE.GetKeyDown(Key.Right) && move != 2)
            {
                move = 0;
                block = 0;

            }
            if (GAME_ENGINE.GetKeyDown(Key.Left) && move != 0)
            {
                move = 2;
                block = 2;
            }
            if (GAME_ENGINE.GetKeyDown(Key.Down) && move != 1)
            {
                move = 3;
                block = 3;
            }
            if (GAME_ENGINE.GetKeyDown(Key.Up) && move != 3)
            {
                block = 1;
                move = 1;
                
            }

            if (GAME_ENGINE.GetKeyDown(Key.A))
            {
                if (extrabreedte.Count > 1)
                {
                    extralengte.Add(extralengte.Last());
                    extrabreedte.Add(extrabreedte.Last());
                }
                else
                {
                    extralengte.Add(currentPosX2);
                    extrabreedte.Add(currentPosY2);
                }
            }

            slow++;
            if (slow == 20)
            {
                slow = 0;
                if (pickY == currentPosY && pickX == currentPosX)
                {
                    if (extrabreedte.Count > 1)
                    {
                        extralengte.Add(extralengte.Last());
                        extrabreedte.Add(extrabreedte.Last());
                    }
                    else
                    {
                        extralengte.Add(currentPosX2);
                        extrabreedte.Add(currentPosY2);
                        
                    }                 
                    pickY = randomGenerator.Next(0, GAME_ENGINE.GetScreenHeight()) / 64;
                    pickX = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 64;
                    pickX = pickX * 64;
                    pickY = pickY * 64;
                    score += 100;

                }
                if (move == 1)
                {
                    currentPosX2 = currentPosX;

                    currentPosY2 = currentPosY;
                    currentPosX -= 64;

                }
                if (move == 2)
                {
                    currentPosY2 = currentPosY;
                    currentPosX2 = currentPosX;
                    currentPosY -= 64;

                }
                if (move == 0)
                {
                    currentPosY2 = currentPosY;
                    currentPosX2 = currentPosX;
                    currentPosY += 64;

                }
                if (move == 3)
                {
                    currentPosX2 = currentPosX;

                    currentPosY2 = currentPosY;
                    currentPosX += 64;

                }
                if (currentPosY > GAME_ENGINE.GetScreenWidth()-64)
                {
                    currentPosY = 0;
                }
                if (currentPosX > GAME_ENGINE.GetScreenHeight()-64)
                {
                    currentPosX = 0;
                }
                if (currentPosX < 0)
                {
                    currentPosX = GAME_ENGINE.GetScreenHeight() - 64;
                }
                if (currentPosY < 0)
                {
                    currentPosY = GAME_ENGINE.GetScreenWidth() - 64;
                }
                for (int i = 0; i < extralengte.Count; i++)
                {
                    if (currentPosX == extralengte[i] && currentPosY == extrabreedte[i])
                    {
                        score -= score;
                        extrabreedte.Clear();
                        extralengte.Clear();
                        currentPosX = 640 / 2;
                        currentPosY = 640 / 2 + 64;
                        currentPosX2 = 640 / 2;
                        currentPosY2 = 640 / 2;
                        extrabreedte.Add(currentPosX2);
                        extralengte.Add(currentPosY2);

                    }

                }
                for (int i = 0; i < extralengte.Count; i++)
                {

                    if (i + 1 < extrabreedte.Count)
                    {
                        extralengte[i] = extralengte[i + 1];
                        extrabreedte[i] = extrabreedte[i + 1];



                    }else
                    {
                        extralengte[i] = currentPosX2;
                        extrabreedte[i] = currentPosY2;
                    }

                }
            }
        }

        public override void Paint()
        {
            GAME_ENGINE.DrawBitmap(Snek, pickY, pickX, 256, 128, 64, 64);
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.FillRectangle(currentPosY, currentPosX, 64, 64);
            for (int i = extrabreedte.Count - 1; i >= 0; i--)
            {
                GAME_ENGINE.FillRectangle(extrabreedte[i], extralengte[i], 64, 64);
            }
            if (move == 0)
            {
                GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 64, 0, 64, 64);
            }
            if (move == 1)
            {
                GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 0, 0, 64, 64);
            }
            if (move == 2)
            {
                GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 192, 0, 64, 64);
            }
            if (move == 3)
            {
                GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 128, 0, 64, 64);
            }
            //GAME_ENGINE.SetColor(0, 230, 210);

            GAME_ENGINE.SetColor(220, 20, 60);
            GAME_ENGINE.DrawString("score: " + score + ".", 0, 0, 200, 200);

        }
    }
}
