using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Snake : AbstractGame
    {

        private bool InMenu = true;

        private List<Vector2> SnakePos = new List<Vector2>();
        private Vector2 m_FirstSnakePos = new Vector2(64, 64);

        private List<int> SnakeDir = new List<int>();

        private Vector2[] m_LastSnakePos;

        private Vector2 ApplePos;

        private int m_SnakeDirection = 2;
        private int m_LastSnakeDirection = 0;
        private int m_DrawDir = 2;

        private bool m_RotateLeftBool = false;
        private bool m_RotateRightBool = false;
        private List<bool> RotateLeft = new List<bool>();
        private List<bool> RotateRight = new List<bool>();


        private int m_Step = 0;


        private int m_Speed = 64;

        private int m_Lengt = 5;

        private int m_Score = 0;
        private int m_Best = 0;

        private bool isKeyPressed = false;

        private Bitmap m_SnakeArt = null;
        private Bitmap m_Logo = null;

        private Font m_Font = null;

        private Button m_Start = null;


        public override void GameStart()
        {
            //Everything that has to happen when the game starts happens here.
            //F.e. initializing objects.
            GAME_ENGINE.SetBackgroundColor(new Color(247, 230, 151));

            InMenu = true;

            Setup();

            m_Start = new Button(Start, "Start", 165, 300, 300, 100);

            m_SnakeArt = new Bitmap("Snake_Graphics.PNG");
            m_Logo = new Bitmap("Logo.PNG");

            m_Font = new Font("Karmatic Arcade", 34);



        }

        public void Setup()
        {
           
            for (int i = 0; i < m_Lengt; i++)
            {
                SnakePos.Add(new Vector2(64 * i, 64));
                SnakeDir.Add(1);
                RotateLeft.Add(false);
                RotateRight.Add(false);

            }
            setSnakePos();


            ApplePos = newApplePos();
        }

        public void Start()
        {
            
            
            Setup();
            InMenu = false;
        }

        public override void GameEnd()
        {
            //Clean up unmanaged objects here (F.e. bitmaps & fonts)

            //For example:
            //m_Bitmap.Dispose();
            //m_Font.Dispose();

            m_SnakeArt.Dispose();
            m_Logo.Dispose();
            m_Font.Dispose();
        }

        public override void Update()
        {
            if (InMenu == false)
            {
                m_LastSnakeDirection = m_SnakeDirection;


                int m_StepSpeed = 15;

                if(m_Lengt > 5)
                {
                    m_StepSpeed = 13;
                }

                if(m_Lengt > 7)
                {
                    m_StepSpeed = 11;
                }

                if(m_Lengt > 10)
                {
                    m_StepSpeed = 9;
                }

                if(m_Lengt > 15)
                {
                    m_StepSpeed = 7;
                }

                if(m_Lengt > 20)
                {
                    m_StepSpeed = 5;
                }

                
                m_Step++;
                if (m_Step > m_StepSpeed)
                {
                    m_Step = 0;
                    MoveSnake(m_SnakeDirection);
                    m_DrawDir = m_SnakeDirection;
                }


                if (isKeyPressed == false)
                {
                    if ((GAME_ENGINE.GetKeyDown(Key.W) || GAME_ENGINE.GetKeyDown(Key.Up)) && m_SnakeDirection != 2)
                    {
                        m_SnakeDirection = 1;
                        isKeyPressed = true;

                        //if (m_LastSnakeDirection != 1)
                        //{
                        //    if (m_LastSnakeDirection == 3)
                        //    {
                        //        m_RotateRightBool = true;
                        //    }
                        //    if (m_LastSnakeDirection == 4)
                        //    {
                        //        m_RotateRightBool = true;
                        //    }
                        //}
                    }

                    if ((GAME_ENGINE.GetKeyDown(Key.S) || GAME_ENGINE.GetKeyDown(Key.Down)) && m_SnakeDirection != 1)
                    {
                        m_SnakeDirection = 2;
                        
                        isKeyPressed = true;

                        //if (m_LastSnakeDirection != 2)
                        //{
                        //    if (m_LastSnakeDirection == 3)
                        //    {
                        //        m_RotateLeftBool = true;
                        //    }
                        //    if (m_LastSnakeDirection == 4)
                        //    {
                        //        m_RotateRightBool = true;
                        //    }
                        //}
                    }


                    if ((GAME_ENGINE.GetKeyDown(Key.D) || GAME_ENGINE.GetKeyDown(Key.Right)) && m_SnakeDirection != 4)
                    {
                        m_SnakeDirection = 3;
                        //m_RotateRightBool = true;
                        isKeyPressed = true;
                        //if (m_LastSnakeDirection != 3)
                        //{
                        //    if (m_LastSnakeDirection == 3)
                        //    {
                        //        m_RotateRightBool = true;
                        //    }
                        //    if (m_LastSnakeDirection == 4)
                        //    {
                        //        m_RotateRightBool = true;
                        //    }
                        //}
                    }

                    if ((GAME_ENGINE.GetKeyDown(Key.A) || GAME_ENGINE.GetKeyDown(Key.Left)) && m_SnakeDirection != 3)
                    {
                        m_SnakeDirection = 4;
                        //m_RotateRightBool = true;
                        isKeyPressed = true;
                        //if (m_LastSnakeDirection != 4)
                        //{
                        //    if (m_LastSnakeDirection == 3)
                        //    {
                        //        m_RotateRightBool = true;
                        //    }
                        //    if (m_LastSnakeDirection == 4)
                        //    {
                        //        m_RotateRightBool = true;
                        //    }
                        //}
                    }
                    if ((GAME_ENGINE.GetKeyUp(Key.N)))
                    {
                        ApplePos = newApplePos();
                    }


                }


                CheckAppleEaten();

                CheckDead();


                //Update everything here.
                //F.e. get input, move objects, etc...

                //For example:
                //float deltaTime = GAME_ENGINE.GetDeltaTime();
                //bool isDown = GAME_ENGINE.GetKeyDown(Key.Right);
            }
        }



        private void MoveSnake(int direction)
        {

            setSnakePos();

            //Boven
            if (direction == 1)
            {
                m_FirstSnakePos.Y -= 1 * m_Speed;
            }

            //Onder
            if (direction == 2)
            {
                m_FirstSnakePos.Y += 1 * m_Speed;
            }

            //Rechts
            if (direction == 3)
            {
                m_FirstSnakePos.X += 1 * m_Speed;
            }

            //Links
            if (direction == 4)
            {
                m_FirstSnakePos.X -= 1 * m_Speed;
            }

            //Outside
            if (m_FirstSnakePos.X > 576)
            {
                m_FirstSnakePos.X = 0;
            }
            if (m_FirstSnakePos.Y > 576)
            {
                m_FirstSnakePos.Y = 0;
            }
            if (m_FirstSnakePos.X < 0)
            {
                m_FirstSnakePos.X = 576;
            }
            if (m_FirstSnakePos.Y < 0)
            {
                m_FirstSnakePos.Y = 576;
            }

            isKeyPressed = false;
            //SetPos
            //SnakePos.Clear();
            //SnakePos.Add(new Vector2(m_FirstSnakePos.X, m_FirstSnakePos.Y));
            //int lengt = 0;
            //foreach (Vector2 Vect in SnakePos)
            //{
            //lengt++;
            //}
            //m_LastSnakePos = new Vector2[lengt];
            //m_LastSnakePos = SnakePos.ToArray();


        }
    
        public Vector2 getSnakePos(int ID)
        {
            return new Vector2(SnakePos[ID].X, SnakePos[ID].Y);
        }

        

        public void setSnakePos()
        {
            Vector2[]LastPos = SnakePos.ToArray();
            int[] LastDir = SnakeDir.ToArray();
            bool[] LastRotateLeft = RotateLeft.ToArray();
            bool[] LastRotateRight = RotateRight.ToArray();
            SnakePos.Clear();
            SnakeDir.Clear();
            RotateLeft.Clear();
            RotateRight.Clear();
            SnakePos.Add(m_FirstSnakePos);
            SnakeDir.Add(m_SnakeDirection);
            RotateLeft.Add(m_RotateLeftBool);
            RotateRight.Add(m_RotateRightBool);
            m_RotateRightBool = false;
            m_RotateRightBool = false;
            for (int i = 0; i < m_Lengt; i++)
            {
                SnakePos.Add(LastPos[i]);
                SnakeDir.Add(LastDir[i]);
                RotateLeft.Add(LastRotateLeft[i]);
                RotateRight.Add(LastRotateRight[i]);
            }
            
        }
        public void AddSnakePos(Vector2 Pos)
        {
            SnakePos.Add(Pos);
        }

        public Vector2 newApplePos()
        {
            Random AppleGen = new Random();

            int x = AppleGen.Next(0, 10);
            int y = AppleGen.Next(0, 10);

            //CheckSpawnedApple(x, y);

            for (int i = 0; i < m_Lengt; i++)
            {
                if (SnakePos[i].X == (x * 64) && SnakePos[i].Y == (y * 64) || m_FirstSnakePos.X == (x * 64) && m_FirstSnakePos.Y == (y * 64))
                {
                    x = AppleGen.Next(0, 10);
                    y = AppleGen.Next(0, 10);

                    i = 0;
                }

            }

            return new Vector2(x * 64, y * 64);

           

        }

        public void CheckSpawnedApple(int x, int y)
        {
            for (int i = 0; i < m_Lengt; i++)
            {
                if (SnakePos[i].X == (x*64)&& SnakePos[i].Y == (y*64) || m_FirstSnakePos.X == (x*64) && m_FirstSnakePos.Y == (y*64))
                {
                    ApplePos = newApplePos();
                }
                
            }
        }
       

        public void CheckAppleEaten()
        {
            if(m_FirstSnakePos.X == ApplePos.X)
            {
                if(m_FirstSnakePos.Y == ApplePos.Y)
                {
                    m_Lengt += 1;
                    ApplePos = newApplePos();
                    m_Score+= 100;
                    


                }
            }
        }

        public void CheckDead()
        {
            for(int i = 0; i < m_Lengt; i++)
            {
                if (SnakePos[i].X == m_FirstSnakePos.X)
                {
                    if(SnakePos[i].Y == m_FirstSnakePos.Y)
                    {
                        if(m_Lengt > 2)
                        {
                            GameStart();
                        }
                        m_Lengt = 2;
                        if(m_Score >= m_Best)
                        {
                            m_Best = m_Score;
                        }
                        m_Score = 0;
                     
                    }
                }
            }
        }

        public override void Paint()
        {
            if(InMenu == true)
            {
                m_Start.SetBorderCornerRadius(new Vector2f(10, 10));
                m_Start.SetBorderColor(new Color(0, 0, 0));
                m_Start.SetBackgroundColor(new Color(247, 230, 151));
                // m_Start.SetForegroundColor(new Color(247, 230, 151));

                

                 m_Start.SetHoverBorderColor(new Color(250, 230, 151));
                 m_Start.SetHoverBackgroundColor(new Color(247, 230, 151));
                // m_Start.SetHoverForegroundColor(new Color(247, 230, 151));

                // m_Start.ShowBackground(true);
                // m_Start.ShowForeground(true);

                m_Font.SetHorizontalAlignment(Font.Alignment.Center);
                m_Font.SetVerticalAlignment(Font.Alignment.Center);

                m_Start.SetFont(m_Font);

                m_Start.SetActive(true);
                GAME_ENGINE.DrawBitmap(m_Logo, 25, 40);

                GAME_ENGINE.DrawString(m_Font,"Best: " + m_Best.ToString(), 250, 450, 150, 150);

            }

            if (InMenu == false)
            {
                m_Start.SetActive(false);
                GAME_ENGINE.DrawInfo(10, 10);
                GAME_ENGINE.DrawString(m_Font,"Score: " + m_Score.ToString(), 250, 250, 150, 150);
                GAME_ENGINE.DrawString(m_Font,"Best: " + m_Best.ToString(), 10, 10, 150, 150);

                int lastDir = 0;
                int nextDir = 0;

                int LastX = m_FirstSnakePos.X;
                int LastY = m_FirstSnakePos.Y;

                //W
                if (m_DrawDir == 1)
                {
                    GAME_ENGINE.DrawBitmap(m_SnakeArt, m_FirstSnakePos.X, m_FirstSnakePos.Y, 0, 0, 64, 64);
                }
                //S
                if (m_DrawDir == 2)
                {
                    GAME_ENGINE.DrawBitmap(m_SnakeArt, m_FirstSnakePos.X, m_FirstSnakePos.Y, 128, 0, 64, 64);
                }
                //D
                if (m_DrawDir == 3)
                {
                    GAME_ENGINE.DrawBitmap(m_SnakeArt, m_FirstSnakePos.X, m_FirstSnakePos.Y, 64, 0, 64, 64);
                }
                //A
                if (m_DrawDir == 4)
                {
                    GAME_ENGINE.DrawBitmap(m_SnakeArt, m_FirstSnakePos.X, m_FirstSnakePos.Y, 192, 0, 64, 64);
                }
                lastDir = m_DrawDir;
                for (int i = 0; i < m_Lengt; i++)
                {

                    int x = getSnakePos(i).X- LastX;
                    int y = getSnakePos(i).Y - LastY;

                    int now = 0;
                    int last = 0;
                    if (i > 1)
                    {
                        now = SnakeDir.Count -  (1*i);
                        last = SnakeDir.Count - (2 * i);
                    }

                    Console.WriteLine(i + " X: " + x);
                    Console.WriteLine(i + " Y: " + y);

                    //General
                    if (RotateLeft[i] != true && RotateRight[i] != true)
                    {

                        //Up Down
                        if (SnakeDir[i] == 1 || SnakeDir[i] == 2)
                        {
                            GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 256, 0, 64, 64);
                        }
                        //Left Right
                        if (SnakeDir[i] == 3 || SnakeDir[i] == 4)
                        {
                            GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 256, 64, 64, 64);
                        }

                    }



                    ////Rotate
                    //else if (RotateLeft[i] == true)
                    //{
                    //    //W
                    //    if (SnakeDir[now] == 1)
                    //    {
                    //        //if (SnakeDir[last] == 3)
                    //        //{
                    //        //    GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 64, 128, 64, 64);
                    //        //}
                    //        if(y == 0)
                    //        {
                    //            GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 256, 0, 64, 64);
                    //        }
                    //        //if (SnakeDir[last] == 4)
                    //        //{
                    //        //    GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 0, 128, 64, 64);
                    //        //}
                    //    }
                    //    //S
                    //    if (SnakeDir[now] == 2)
                    //    {
                    //        //if (SnakeDir[last] == 3)
                    //        //{
                    //            GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 128, 128, 64, 64);
                    //        //}
                    //        if( y == 0)
                    //        {
                    //            GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 256, 0, 64, 64);
                    //         }
                    //        //if (SnakeDir[last] == 4)
                    //        //{
                    //         //   GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 192, 128, 64, 64);
                    //       // }
                    //    }
                    //    //D
                    //    if (SnakeDir[now] == 3)
                    //    {
                    //        //if (x == 64)
                    //        //{
                    //        //    GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 64, 128, 64, 64);
                    //        //}
                    //        if(x == 0)
                    //        {
                    //            GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 256, 64, 64, 64);
                    //        }
                    //        //if (x == -64)
                    //        //{
                    //        //    GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 64, 128, 64, 64);
                    //        //}
                    //    }
                    //    //A
                    //    if (SnakeDir[now] == 4)
                    //    {
                    //        //if (x == 64)
                    //        //{
                    //        //    GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 128, 128, 64, 64);
                    //        //}
                    //        if(x == 0)
                    //        {
                    //            GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 256, 64, 64, 64);
                    //        }
                    //        //if (x == -64)
                    //        //{
                    //        //    GAME_ENGINE.DrawBitmap(m_SnakeArt, getSnakePos(i).X, getSnakePos(i).Y, 128, 128, 64, 64);
                    //        //}
                    //    }
                    //}

                    //LastX = getSnakePos(i).X;
                    //LastY = getSnakePos(i).Y;
                    //lastDir = SnakeDir[i];
                }

                GAME_ENGINE.DrawBitmap(m_SnakeArt, ApplePos.X, ApplePos.Y, 256, 128, 64, 64);
                //Draw everything here.

                //For example:
                //GAME_ENGINE.DrawRectangle(10, 10, 150, 25);
                //GAME_ENGINE.FillEllipse(50, 75, 50, 50);
            }
        }
    }
}
