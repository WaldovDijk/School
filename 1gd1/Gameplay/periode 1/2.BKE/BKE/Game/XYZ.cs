using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class BKE : AbstractGame
    {
        private int i = 0;
        private int Kleur = 1;
        private Boolean Red;
        private Boolean Orange;
        private Boolean Green;
        int counter;
        int xPos;
        int yPos;
        public bool player1Turn = true;
        int[,] TicTacToeField = new int[3, 3];
        bool didPlayer1Win = false, didPlayer2Win = false, gameEnd = false;
        public override void GameStart()
        {
            for ( i = 0; i < 3; i++)
            {
                for ( int j = 0; j < 3; j++)
                {
                    TicTacToeField[i, j] = 0;
                }
            }
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

            Vector2 MousePos = GAME_ENGINE.GetMousePosition();
            xPos = MousePos.X;
            yPos = MousePos.Y;

            counter = counter + 1;

            //Trafficlight switch
            if (i >= 0)
            {
                i++;
            }

            float deltaTime = GAME_ENGINE.GetDeltaTime();
            bool isDown = GAME_ENGINE.GetKeyDown(Key.Enter);

            if (isDown == true)
            {
                Kleur++;
            }
            if (Kleur == 1)
            {
                Orange = false;
                Green = false;
                Red = true;
            }
            if (Kleur == 3)
            {
                Orange = true;
                Green = false;
                Red = false;
            }
            if (Kleur == 2)
            {
                Orange = false;
                Green = true;
                Red = false;
            }
            if (Kleur == 4)
            {
                Kleur = 1;
            }
        


            //BoterKaasEieren Keys
            if (GAME_ENGINE.GetKeyDown(Key.NumPad7))
            {
                if (TicTacToeField[0, 0] == 0 && !gameEnd)
                {
                    TicTacToeField[0, 0] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }

            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad4))
            {
                if (TicTacToeField[0, 1] == 0 && !gameEnd)
                {
                    TicTacToeField[0, 1] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad8))
            {
                if (TicTacToeField[1, 0] == 0 && !gameEnd)
                {
                    TicTacToeField[1, 0] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad9))
            {
                if (TicTacToeField[2, 0] == 0 && !gameEnd)
                {
                    TicTacToeField[2, 0] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad5))
            {
                if (TicTacToeField[1, 1] == 0 && !gameEnd)
                {
                    TicTacToeField[1, 1] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad6))
            {
                if (TicTacToeField[2, 1] == 0 && !gameEnd)
                {
                    TicTacToeField[2, 1] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad1))
            {
                if (TicTacToeField[0, 2] == 0 && !gameEnd)
                {
                    TicTacToeField[0, 2] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad2))
            {
                if (TicTacToeField[1, 2] == 0 && !gameEnd)
                {
                    TicTacToeField[1, 2] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad3))
            {
                if (TicTacToeField[2, 2] == 0 && !gameEnd)
                {
                    TicTacToeField[2, 2] = Convert.ToInt32(!player1Turn) + 1;
                    player1Turn = !player1Turn;
                    didPlayer1Win = checkForWin(TicTacToeField, 1);
                    didPlayer2Win = checkForWin(TicTacToeField, 2);
                    gameEnd = didPlayer1Win || didPlayer2Win || checkForGameEnd(TicTacToeField);
                }
            }
            if (GAME_ENGINE.GetKeyDown(Key.NumPad0))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        TicTacToeField[i, j] = 0;
                    }
                }
                player1Turn = true;
                didPlayer1Win = false; didPlayer2Win = false;
                gameEnd = false;
            }


            //Update everything here.
            //F.e. get input, move objects, etc...

            //For example:
            //float deltaTime = GAME_ENGINE.GetDeltaTime();
            //bool isDown = GAME_ENGINE.GetKeyDown(Key.Right);
        }

        public override void Paint()
        {
            //MousePos
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.DrawString("X:" + xPos.ToString(), 600, 10, 100, 20);
            GAME_ENGINE.DrawString("Y:" + yPos.ToString(), 600, 30, 100, 20);

            //Name
            GAME_ENGINE.DrawString("Waldo van Dijk", 10, 10, 100, 20);
            GAME_ENGINE.DrawString("1GD1", 10, 20, 100, 20);

            //Counter
            GAME_ENGINE.DrawString(counter.ToString(), 10, 50, 100, 10);



            //stoplicht
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.DrawString("2: ", 20, 80, 250, 50);
            GAME_ENGINE.SetColor(80, 80, 80);
            GAME_ENGINE.FillRectangle(30, 80, 30, 100);
            //paal
            GAME_ENGINE.SetColor(80, 80, 80);
            GAME_ENGINE.FillRectangle(40, 180, 10, 40);

            //RedOutline
            GAME_ENGINE.SetColor(255, 0, 0);
            GAME_ENGINE.DrawEllipse(45, 95, 12, 12);
            //OragneOutline
            GAME_ENGINE.SetColor(255, 165, 0);
            GAME_ENGINE.DrawEllipse(45, 125, 12, 12);
            //GreenOutline
            GAME_ENGINE.SetColor(0, 255, 0);
            GAME_ENGINE.DrawEllipse(45, 155, 12, 12);
            GAME_ENGINE.SetColor(0, 0, 0);

            if (Green == true)
            {
                //green
                GAME_ENGINE.SetColor(0, 255, 0);
                GAME_ENGINE.FillEllipse(45, 155, 12, 12);
                GAME_ENGINE.SetColor(0, 0, 0);
            }
            if (Orange == true)
            {
                //Orange
                GAME_ENGINE.SetColor(255, 165, 0);
                GAME_ENGINE.FillEllipse(45, 125, 12, 12);
                GAME_ENGINE.SetColor(0, 0, 0);
            }
            if (Red == true)
            {
                //Red
                GAME_ENGINE.SetColor(255, 0, 0);
                GAME_ENGINE.FillEllipse(45, 95, 12, 12);
                GAME_ENGINE.SetColor(0, 0, 0);
            }


            //BOTERKAASENEIEREN DRAW
            GAME_ENGINE.SetColor(255, 255, 255);
            GAME_ENGINE.FillRectangle(200, 100, 300, 300);





            //TicTacToeFieldDraw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    GAME_ENGINE.SetColor(0, 0, 0);
                    GAME_ENGINE.DrawRectangle(200 + i * 100, 100 + j * 100, 100, 100);
                    if (TicTacToeField[i, j] == 1)
                    {
                        GAME_ENGINE.SetColor(255, 0, 0);
                        GAME_ENGINE.FillEllipse(250 + i * 100, 150 + j * 100, 50, 50);
                    }
                    if (TicTacToeField[i, j] == 2)
                    {
                        GAME_ENGINE.SetColor(0, 0, 255);
                        GAME_ENGINE.FillRectangle(200 + i * 100, 100 + j * 100, 98, 98);
                    }
                }
            }
           

            //Winner Draw
            GAME_ENGINE.SetColor(0, 0, 0);
            if (!didPlayer1Win && !didPlayer2Win && gameEnd)
            {
                GAME_ENGINE.DrawString("DRAW!!", 250, 350, 50, 50);
            }
            else if (didPlayer1Win)
            {

                GAME_ENGINE.DrawString("Player1 Wins", 250, 400, 400, 50);
            }
            else if (didPlayer2Win)
            {
                GAME_ENGINE.DrawString("Player2 Wins", 250, 400, 400, 50);
            }

            GAME_ENGINE.DrawString(GAME_ENGINE.GetKeyDown(Key.NumPad2).ToString(), 200, 50, 50, 50);
            GAME_ENGINE.DrawString(TicTacToeField[0, 1].ToString(), 200, 60, 10, 10);
            GAME_ENGINE.DrawString((Convert.ToInt32(!player1Turn) + 1).ToString(), 200, 70, 10, 10);

            GAME_ENGINE.SetColor(255, 255, 255);

        }

        public static bool checkForWin(int[,] Grid, int playerToCheck)
        {
            //Diagonal check
            if (Grid[0, 0] == playerToCheck && Grid[1, 1] == playerToCheck && Grid[2, 2] == playerToCheck)
                return true;
            if (Grid[0, 2] == playerToCheck && Grid[1, 1] == playerToCheck && Grid[2, 0] == playerToCheck)
                return true;
            for (int i = 0; i < 3; i++)
            {
                if (Grid[i, 0] == playerToCheck && Grid[i, 1] == playerToCheck && Grid[i, 2] == playerToCheck)
                    return true;
                if (Grid[0, i] == playerToCheck && Grid[1, i] == playerToCheck && Grid[2, i] == playerToCheck)
                    return true;
            }

            return false;
        }
        public static bool checkForGameEnd(int[,] Grid)
        {
            //Check for Draw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Grid[i, j] == 0)
                        return false;
                }
            }
            return true;
        }
    }
}
