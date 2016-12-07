using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class EngineGame : AbstractGame
    {
        public override void GameStart()
        {
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
            //Update everything here.
            //F.e. get input, move objects, etc...

            //For example:
            //float deltaTime = GAME_ENGINE.GetDeltaTime();
            //bool isDown = GAME_ENGINE.GetKeyDown(Key.Right);
        }

        public override void Paint()
        {
            //Draw everything here.

            GAME_ENGINE.SetColor(0, 0, 0);
            //naam:
            GAME_ENGINE.DrawString("1: Waldo van Dijk", 5, 20, 250, 50);
            
            //Huisje:
            GAME_ENGINE.DrawString("2: ", 5, 80, 250, 50);
            GAME_ENGINE.DrawRectangle(20, 80, 50, 50);
            GAME_ENGINE.DrawLine(20, 80, 45, 35);
            GAME_ENGINE.DrawLine(70, 80, 45, 35);
            
            //vlag
            GAME_ENGINE.DrawString("3: ", 5, 150, 250, 50);

            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.FillRectangle(20, 150, 20, 50 );

            GAME_ENGINE.SetColor(255, 255, 0);
            GAME_ENGINE.FillRectangle(40, 150, 20, 50);

            GAME_ENGINE.SetColor(255, 0, 0); //Neem het rode "kleurpotlood"
            GAME_ENGINE.FillRectangle(60, 150, 20, 50);
            GAME_ENGINE.SetColor(0, 0, 0);

            //blok zwart wit
            GAME_ENGINE.DrawString("4: ", 5, 220, 250, 50);

            GAME_ENGINE.DrawRectangle(20, 220, 60, 60);
            //line 1
            GAME_ENGINE.FillRectangle(20, 220, 20, 20);
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillRectangle(40, 220, 20, 20);
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.FillRectangle(60, 220, 20, 20);
            //line 2
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillRectangle(20, 240, 20, 20);
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.FillRectangle(40, 240, 20, 20);
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillRectangle(60, 240, 20, 20);
            //line 3
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.FillRectangle(20, 260, 20, 20);
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillRectangle(40, 260, 20, 20);
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.FillRectangle(60, 260, 20, 20);
            GAME_ENGINE.SetColor(255, 255, 255);

            //stoplicht
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.DrawString("5: ", 235, 20, 250, 50);
            GAME_ENGINE.SetColor(80, 80, 80);
            GAME_ENGINE.FillRectangle(250, 20, 30, 90);
            //paal
            GAME_ENGINE.SetColor(80, 80, 80);
            GAME_ENGINE.FillRectangle(260, 110, 10, 40);
            //red
            GAME_ENGINE.SetColor(255, 0, 0);
            GAME_ENGINE.FillEllipse(265, 40, 12, 12);
            //Orange
            GAME_ENGINE.SetColor(255, 165, 0);
            GAME_ENGINE.FillEllipse(265, 65, 12, 12);
            //green
            GAME_ENGINE.SetColor(0, 255, 0);
            GAME_ENGINE.FillEllipse(265, 90, 12, 12);

            //dobblesteen
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.DrawString("6.", 200, 240, 100, 10);
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillRoundedRectangle(230, 250, 100, 100, 10, 10);
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.DrawRoundedRectangle(230, 250, 100, 100, 10, 10, 5);
            GAME_ENGINE.FillEllipse(250, 270, 7, 7);
            GAME_ENGINE.FillEllipse(280, 300, 7, 7);
            GAME_ENGINE.FillEllipse(310, 330, 7, 7);
            GAME_ENGINE.SetColor(0, 0, 0);

            Bitmap link;
            link = new Bitmap("link.bmp");
            GAME_ENGINE.DrawBitmap(link, 400, 280);
            GAME_ENGINE.DrawString("8. link", 400, 280, 250, 50);

            Bitmap mario;
            mario = new Bitmap("mario.bmp");
            GAME_ENGINE.DrawBitmap(mario, 400, 20);
            GAME_ENGINE.DrawString("8. mario", 400, 20, 250, 50);

        }
    }
}
