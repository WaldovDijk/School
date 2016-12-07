using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Preload : AbstractGame
    {
        //private int MainMenu = 0;

        Paddle player1 = new Paddle();
        Paddle player2 = new Paddle();

        Ball balletje = new Ball();
        //private Button Main = null;
        //private Button options = null;
        public override void GameStart()
        {

            //Main = new Button(MainButton, "Lets Start!", 200, 300, 400, 200);
           // options = new Button(Start2, "2 Players", 200, 300,400,70);
            //Everything that has to happen when the game starts happens here.
            //F.e. initializing objects.
        }
        /*public void MainButton()
        {
            MainMenu = 1;
        }
        public void Start2()
        {
            MainMenu = 2;
        }
        */
        public override void GameEnd()
        {
            //Clean up unmanaged objects here (F.e. bitmaps & fonts)

            //For example:
            //m_Bitmap.Dispose();
            //m_Font.Dispose();
        }

        public override void Update()
        {
            player1.Update(1);
            player2.Update(2);
        }

        public override void Paint()
        {
            player1.Paint(750);
            player2.Paint(10);
        }
    }
}
