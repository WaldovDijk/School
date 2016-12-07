using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Ball
    {
        private bool Begin;
        private float ball_X = 400;
        private float ball_Y = 400;
        private float Ball_S = 300;
        private float Ball_SY = 300;
        private GameEngine GAME_ENGINE;
        public Ball()
        {
            GAME_ENGINE = GameEngine.GetInstance();
        }
        public void Update(float X, float Y)
        {
            float deltaTime = GAME_ENGINE.GetDeltaTime();
            ball_X += Ball_S * deltaTime;
            ball_Y += Ball_SY * deltaTime;
            if ((ball_X - 10 >= 10 && ball_X - 10 <= 10 + 41) && (ball_Y - 10 >= X && ball_Y - 10 <= X + 151))
            {
                if (Ball_SY == 0)
                {
                    Ball_SY = 300;
                }
                if (Begin == true)
                {
                    Ball_S = Ball_S - (Ball_S * 2) + 30;
                    Begin = false;
                }
                if (Begin == false)
                {
                    Ball_S = Ball_S - (Ball_S * 2) + 30;
                }
            }
            //out of bounce top
            if (ball_Y >= 790)
            {
                Ball_SY = -(Ball_SY);
            }
            //out of bounce bottom
            if (ball_Y <= 10)
            {
                Ball_SY = Ball_SY - (Ball_SY * 2) + 30;
            }
        }
        public void Paint()
        {
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillEllipse(ball_X, ball_Y, 10, 10);
        }
    }
}
