using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Preload : AbstractGame
    {

        private bool Wdown;
        private bool Sdown;
        private float X = 640;
        private float Y_speed = 800;
        private float Y = 728;

        private int score = 0;
        private float Y_E = 120;
        private float ball_Y = 100;
        private float ball_X = 400;
        private float Ball_S;
        private float Ball_SY;
        private bool[] enemy = new bool[5];
        private bool spatie;
        private bool win;
        public override void GameStart()
        {
            
            if (spatie == true)
            {
                Ball_S = 300;
                Ball_SY = -300;
            }
        }

        public override void GameEnd()
        {

        }

        public override void Update()
        {

            float deltaTime = GAME_ENGINE.GetDeltaTime();

            ball_X += Ball_S * deltaTime;
            ball_Y += Ball_SY * deltaTime;
            //player 1 up
            if (GAME_ENGINE.GetKey(Key.A) && (X >= 0 || X <= 1280))
            {
                Wdown = true;
            }
            else
            {
                Wdown = false;
            }
            //player 1 down
            if (GAME_ENGINE.GetKey(Key.D) && (X <= 1280 || X <= 0))
            {
                Sdown = true;
            }
            else
            {
                Sdown = false;
            }
            //W and S movement
             if (Wdown == true)
             {
                X -= Y_speed * deltaTime;
             }
             if (Sdown == true)
             {
                X += Y_speed * deltaTime;
             }
            //Player 1 out of map protection
            if (X <= 0)
            {
                X = 0;
            }
            if (X >= 1130)
            {
                X = 1130;
            }

            if ((ball_Y + 10 >= Y && ball_Y + 10 <= Y + 41) && (ball_X + 10 >= X && ball_X + 10 <= X + 151))
            {
                Ball_SY = Ball_SY - (Ball_SY * 2);
                Console.WriteLine("het balletje raakt");
            }
            //enemys
            if (enemy[0] == false)
            {
                if ((ball_Y - 10 >= Y_E && ball_Y - 10 <= Y_E + 41) && (ball_X + 10 >= 150 && ball_X + 10 <= 150 + 150))
                {
                    Ball_SY = Ball_SY - (Ball_SY * 2);
                    Console.WriteLine("het balletje raakt");
                    score += 100;
                    enemy[0] = true;
                }
            }
            if (enemy[1] == false)
            {
                if ((ball_Y - 10 >= Y_E && ball_Y - 10 <= Y_E + 41) && (ball_X + 10 >= 300 && ball_X + 10 <= 300 + 150))
                {
                    Ball_SY = Ball_SY - (Ball_SY * 2);
                    Console.WriteLine("het balletje raakt");
                    enemy[1] = true;
                    score += 100;
                }
            }
            if (enemy[2] == false)
            {
                if ((ball_Y - 10 >= Y_E && ball_Y - 10 <= Y_E + 41) && (ball_X + 10 >= 450 && ball_X + 10 <= 450 + 150))
                {
                    Ball_SY = Ball_SY - (Ball_SY * 2);
                    Console.WriteLine("het balletje raakt");
                    enemy[2] = true;
                    score += 100;
                }
            }
            if (enemy[3] == false)
            {
                if ((ball_Y - 10 >= Y_E && ball_Y - 10 <= Y_E + 41) && (ball_X + 10 >= 600 && ball_X + 10 <= 600 + 150))
                {
                    Ball_SY = Ball_SY - (Ball_SY * 2);
                    Console.WriteLine("het balletje raakt");
                    enemy[3] = true;
                    score += 100;
                }
            }
            if (enemy[4] == false)
            {
                if ((ball_Y - 10 >= Y_E && ball_Y - 10 <= Y_E + 41) && (ball_X + 10 >= 750 && ball_X + 10 <= 750 + 150))
                {
                    Ball_SY = Ball_SY - (Ball_SY * 2);
                    Console.WriteLine("het balletje raakt");
                    enemy[4] = true;
                    score += 100;
                }
            }
            if (spatie == false)
            {
                Ball_S = 0;
                Ball_SY = 0;
                ball_Y = Y - 10;
                ball_X = X + 75;
            }
            if (GAME_ENGINE.GetKey(Key.Space))
            {
                spatie = true;
                
                if (spatie == true)
                {
                    Ball_S = 300;
                    Ball_SY = -300;
                }
            }
            //out of bounce Top
            if (ball_Y <= 10)
            {
                ball_Y = 12;
                Ball_SY = -(Ball_SY);
            }
            //out of bounce Bot
            if (ball_Y >= 768)
            {
                score = 0;
                spatie = false;
                 X = 640;
                 Y = 728;
                enemy[0] = false;
                enemy[1] = false;
                enemy[2] = false;
                enemy[3] = false;
                enemy[4] = false;
            }
            //out of bounce right
            if (ball_X >= 1270)
            {
                Ball_S = -(Ball_S);
            }
            //out of bounce Left
            if (ball_X <= 10)
            {
                ball_X = 12;
                Ball_S = Ball_S - (Ball_S * 2);
            }
            if (score == 500)
            {
                win = true;
            }
            
        }

        public override void Paint()
        {
            if (win == true)
            {
                GAME_ENGINE.DrawString("Score:" + score + ".", 200, 200, 2000, 200);
                GAME_ENGINE.DrawString("YOU WON YOU WANKER", 200, 220, 2000, 200);
            }
            if (win == false)
            {
                GAME_ENGINE.SetColor(255, 255, 255);
                GAME_ENGINE.FillEllipse(ball_X, ball_Y, 10, 10);
                GAME_ENGINE.SetColor(255, 255, 255);
                GAME_ENGINE.FillRectangle(X, Y, 150, 40);

                GAME_ENGINE.DrawString("Score:" + score + ".", 20, 20, 2000, 200);
                if (enemy[0] == false)
                {
                    GAME_ENGINE.FillRectangle(150, Y_E, 150, 40);
                }
                if (enemy[1] == false)
                {
                    GAME_ENGINE.FillRectangle(300, Y_E, 150, 40);
                }
                if (enemy[2] == false)
                {
                    GAME_ENGINE.FillRectangle(450, Y_E, 150, 40);
                }
                if (enemy[3] == false)
                {
                    GAME_ENGINE.FillRectangle(600, Y_E, 150, 40);
                }
                if (enemy[4] == false)
                {
                    GAME_ENGINE.FillRectangle(750, Y_E, 150, 40);
                }
            }
           
        }
    }
}
