using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Paddle
    {

        private bool Wdown;
        private bool Sdown;
        private bool Udown;
        private bool Ddown;
        private int control;
        private float X;
        private float Y_speed = 800;
        private float Y = 300;
        Ball balletje = new Ball();
        private GameEngine GAME_ENGINE;
        public Paddle()
        {
            GAME_ENGINE = GameEngine.GetInstance();
        }
        public void Update(int control)
        {
            balletje.Update(X, Y);
            float deltaTime = GAME_ENGINE.GetDeltaTime();
            GAME_ENGINE.SetVSync(false);
            if (control == 2)
            {
                //player 1 up
                if (GAME_ENGINE.GetKey(Key.W) && (Y >= 0 || Y <= 800))
                {
                    Wdown = true;
                }
                else
                {
                    Wdown = false;
                }
                //player 1 down
                if (GAME_ENGINE.GetKey(Key.S) && (Y <= 800 || Y <= 0))
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
                    Y -= Y_speed * deltaTime;
                }
                if (Sdown == true)
                {
                    Y += Y_speed * deltaTime;
                }
            }
            if (control == 1)
            {
                //player 2 up
                if (GAME_ENGINE.GetKey(Key.Up) && (Y >= 0 || Y <= 800))
                {
                    Udown = true;
                }
                else
                {
                    Udown = false;
                }
                //player 1 down
                if (GAME_ENGINE.GetKey(Key.Down) && (Y <= 800 || Y <= 0))
                {
                    Ddown = true;
                }
                else
                {
                    Ddown = false;
                }
                if (Udown == true)
                {
                    Y -= Y_speed * deltaTime;
                }
                if (Ddown == true)
                {
                    Y += Y_speed * deltaTime;
                }
            }
            //Player 1 out of map protection
            if (Y <= 0)
            {
                Y = 0;
            }
            if (Y >= 650)
            {
                Y = 650;
            }

        }
        public void Paint(float X)
        {
            m_GameEngine.SetColor(255, 255, 255);
            m_GameEngine.FillRectangle(X, Y, 40, 150);
            balletje.Paint();
        }
    }
}
