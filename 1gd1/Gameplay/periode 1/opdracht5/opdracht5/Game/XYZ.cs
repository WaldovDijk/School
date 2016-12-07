using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class opdracht5 : AbstractGame
    {
        private Bitmap m_BMPIdle = null;
        private Bitmap m_BMPBored = null;
        private Bitmap[] run = new Bitmap[4];
        private int h = 0;
        private int h1 = 0;
        private int n = 0;
        private int n1 = 0;
        public override void GameStart()
        {
            m_BMPIdle = new Bitmap("Jazz_Idle.png");
            m_BMPBored = new Bitmap("Jazz_Bored.png");
            run[0] = new Bitmap("Jazz_Run_0.png");
            run[1]= new Bitmap("Jazz_Run_1.png");
            run[2] = new Bitmap("Jazz_Run_2.png");
            run[3] = new Bitmap("Jazz_Run_3.png");

        }

        public override void GameEnd()
        {
            //Clean up unmanaged objects here (F.e. bitmaps & fonts)

            //For example:
            //m_Bitmap.Dispose();
            m_BMPIdle.Dispose();

        }

        public override void Update()
        {
            n++;
            n1++;    
            if (n == 5)
            {
                n = 0;
                h++;
                if (h == 4)
                {
                    h = 0;
                }
            }
            if (n1 == 10)
            {
                n1 = 0;
                h1++;
                if (h1 == 13 )
                {
                    h1 = 0;
                }
            }
         
            
                //Update everything here.
                //F.e. get input, move objects, etc...

                //For example:
                //float deltaTime = GAME_ENGINE.GetDeltaTime();
                //bool isDown = GAME_ENGINE.GetKeyDown(Key.Right);
            }

        public override void Paint()
        {
            GAME_ENGINE.DrawString("Waldo van dijk", 10, 10 ,200, 10);
            GAME_ENGINE.DrawString("1GD1", 10, 20, 200, 10);

            //1.
            GAME_ENGINE.DrawString("1.", 10, 40, 200, 10);
            GAME_ENGINE.DrawBitmap(m_BMPIdle, 20, 40);

            //2.
            GAME_ENGINE.DrawBitmap(run[h], 30, 120);

            //3.
            if (h1 == 0)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 8, 0, 59, 72);
            }
            if (h1 == 1)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 80, 0, 59, 72);
            }
            if (h1 == 2 || h1 == 8)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 148, 0, 59, 72);
            }
            if (h1 == 3 || h1 == 9)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 220, 0, 59, 72);
            }
            if (h1 == 4 || h1 == 10)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 294, 0, 59, 72);
            }
            if (h1 == 5 || h1 == 11)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 368, 0, 59, 72);
            }
            if (h1 == 6 || h1 == 12)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 436, 0, 59, 72);
            }
            if (h1 == 7 || h1 == 13)
            {
                GAME_ENGINE.DrawBitmap(m_BMPBored, 20, 200, 508, 0, 59, 72);
            }






        }
    }
}
