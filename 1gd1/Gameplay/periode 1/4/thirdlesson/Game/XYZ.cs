using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class XYZ : AbstractGame
    {
        private Button m_Button = null;
        public override void GameStart()
        {

            //top 1
            m_Button = new Button(OnButtonClick, "CE", 0, 70, 80, 60);
            m_Button = new Button(OnButtonClickP, "+", 240, 70, 80, 60);
            //row 2
            m_Button = new Button(OnButtonClick, "7", 0, 130, 80, 60);
            m_Button = new Button(OnButtonClick, "8", 80, 130, 80, 60);
            m_Button = new Button(OnButtonClick, "9", 160, 130, 80, 60);
            m_Button = new Button(OnButtonClickM, "-", 240, 130, 80, 60);
            //row 3
            m_Button = new Button(OnButtonClick, "4", 0, 190, 80, 60);
            m_Button = new Button(OnButtonClick, "5", 80, 190, 80, 60);
            m_Button = new Button(OnButtonClick, "6", 160, 190, 80, 60);
            m_Button = new Button(OnButtonClickT, "X", 240, 190, 80, 60);
            //row 4
            m_Button = new Button(OnButtonClick, "1", 0, 250, 80, 60);
            m_Button = new Button(OnButtonClick, "2", 80, 250, 80, 60);
            m_Button = new Button(OnButtonClick, "3", 160, 250, 80, 60);
            m_Button = new Button(OnButtonClickD, "/", 240, 250, 80, 60);
            //row 5
            m_Button = new Button(OnButtonClick, "0", 80, 310, 80, 60);
            m_Button = new Button(OnButtonClickE, "=", 240, 310, 80, 60);
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
            //naam:
            GAME_ENGINE.DrawString("Waldo van Dijk", 0, 00, 250, 50);
            //klas:
            GAME_ENGINE.DrawString("1GD1", 0, 10, 250, 50);
        }
        private void OnButtonClickP()
        {
            Console.WriteLine("Hallo, ik ben een knop!");
        }
        private void OnButtonClickM()
        {
            Console.WriteLine("Hallo, ik ben een knop!");
        }
        private void OnButtonClickT()
        {
            Console.WriteLine("Hallo, ik ben een knop!");
        }
        private void OnButtonClickD()
        {
            Console.WriteLine("Hallo, ik ben een knop!");
        }
        private void OnButtonClickE()
        {
            Console.WriteLine("Hallo, ik ben een knop!");
        }
        private void OnButtonClick()
        {
            Console.WriteLine("Hallo, ik ben een knop!");
        }
    }
}
