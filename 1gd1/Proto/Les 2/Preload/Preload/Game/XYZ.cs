using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Preload : AbstractGame
    {
        private int x = 0;
        private int y = 0;
        public float p1_SpeedX;
        public float p1_posX = 590;
        public float b_speed = 668;
        public bool A_move = false;
        public bool D_move = false;
        public bool Left_move = false;
        public bool Right_move = false;
        private bool Shoot = false;
        private float CurrentX;
        private int blokje;
        private bool block = true;
        private int score = 0;
        public Random randomGenerator = new Random();

        private Bitmap Ship = null;
        private Bitmap Bullet = null;
        public override void GameStart()
        {
            Ship = new Bitmap("ship3.png");
            Bullet = new Bitmap("bullet.png");
            x = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 10;
            x = x * 10;
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
            float deltaTime = GAME_ENGINE.GetDeltaTime();
            p1_posX += p1_SpeedX * deltaTime;
            b_speed += p1_SpeedX * deltaTime;
            //player right
            if (GAME_ENGINE.GetKey(Key.D) && (p1_posX >= -1 || p1_posX <= 792))
            {
                D_move = true;
            }
            else
            {
                D_move = false;
            }
            if (GAME_ENGINE.GetKey(Key.Right) && (p1_posX >= -1 || p1_posX <= 792))
            {
                Right_move = true;
            }
            else
            {
                Right_move = false;
            }
            //player left
            if (GAME_ENGINE.GetKey(Key.A) && (p1_posX >= -1 || p1_posX <= 792))
            {
                A_move = true;
            }
            else
            {
                A_move = false;
            }
            if (GAME_ENGINE.GetKey(Key.Left) && (p1_posX >= -1 || p1_posX <= 792))
            {
                Left_move = true;
            }
            else
            {
                Left_move = false;
            }
            //W, S, A and D movement
            if (A_move == true)
            {
                p1_posX -= 6;
            }
            if (Left_move == true)
            {
                p1_posX -= 6;
            }
            if (D_move == true)
            {
                p1_posX += 6;
            }
            if (Right_move == true)
            {
                p1_posX += 6;
            }

            //Player 1 out of map protection
            if (p1_posX <= 0)
            {
                p1_posX = 0;
            }
            if (p1_posX >= 1180)
            {
                p1_posX = 1180;
            }
            //shoot
            if (GAME_ENGINE.GetKey(Key.Space))
            {
                Shoot = true;
                if (blokje == 0)
                {
                    CurrentX = p1_posX + 45;
                    blokje = 1;
                }
                if (b_speed <= 0 )
                {
                    Shoot = false;
                    b_speed = 668;
                    blokje = 0;

                }
            }
            if (Shoot == true)
            {
                b_speed -= 8;
            }


            if (y <= 768)
            {
                y += 3;
            }

            if (y >= 768)
            {
                score -= 100;
                block = false;
                x = randomGenerator.Next(0, GAME_ENGINE.GetScreenHeight()) / 40;
                x = x * 40;
                y = 0;
                block = true;
            }
            if ((CurrentX >= x && CurrentX <= x + 41) && (b_speed >= y && b_speed <= y + 41))
            {
                score += 100;
                block = false;
                Shoot = false;
                b_speed = 668;
                blokje = 0;
                x = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 40;
                x = x * 40;
                y = 0;
                block = true;

            }
        }

        public override void Paint()
        {
            
            if (Shoot == true)
            {
                GAME_ENGINE.SetColor(255, 255, 255);
                GAME_ENGINE.DrawBitmap(Bullet, CurrentX, b_speed);
                GAME_ENGINE.SetColor(0, 0, 0);
            }
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.DrawString("Score: " + score + ".", 230, 0, 2000, 200);
            if (block == true)
            {
                GAME_ENGINE.SetColor(255, 255, 255);
                GAME_ENGINE.FillRectangle(x, y, 40, 40);
                GAME_ENGINE.SetColor(0, 0, 0);
            }
            GAME_ENGINE.DrawBitmap(Ship, p1_posX, 668);
        }
    }
}
