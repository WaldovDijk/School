using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class opdracht6 : AbstractGame
    {
        //audio
        Audio BackgroundMusic = new Audio("Ameno.WAV");
        
        //int's
        private int slow = 0;
        private int move = 0;
        private int currentPosX = 640 / 2;
        private int currentPosY = 640 / 2 + 64;
        private int currentPosX2 = 640 / 2;
        private int currentPosY2 = 640 / 2;
        private int speed = 0;
        private int highscore = 0;
        private int score = 0;
        private int pickY;
        private int pickX;
        private int volume = 50;
        //Booleans
        private bool main = false;

        //randoms
        public Random randomGenerator = new Random();
        //Strings
        //Bitmaps
        private Bitmap Snek = null;
        private Bitmap Logo = null;
        //list
        List<int> extralengte = new List<int>();
        List<int> extrabreedte = new List<int>();
        //buttons
        private Button Begin;

        public override void GameStart()
        {
            //audo play + loop
            BackgroundMusic.SetLooping(true);
            GAME_ENGINE.PlayAudio(BackgroundMusic);
            //Default Volume
            BackgroundMusic.SetVolume(volume);
            //Button creation
            Begin = new Button(StartClick, "Begin!!", 220, 340, 200, 100);
            //Logo main Menu
            Logo = new Bitmap("Logo.png");
            Snek = new Bitmap("Snake_Graphics.png");
            //Spawning position Apple
            pickY = randomGenerator.Next(0, GAME_ENGINE.GetScreenHeight()) / 64;
            pickX = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 64;
            pickX = pickX * 64;
            pickY = pickY * 64;
            extrabreedte.Add(currentPosX2);
            extralengte.Add(currentPosY2);
        }
        public void StartClick()
        {
            main = true;
        }
        public void StartSettings()
        {

        }

        public override void GameEnd()
        {

        }

        public override void Update()
        {
            //Highscore
            if (score > highscore)
            {
                highscore = score;
            }
        
            //Key Right 
            if (GAME_ENGINE.GetKeyDown(Key.Right) && move != 2)
            {
                move = 0;

            }
            //Key Up
            if (GAME_ENGINE.GetKeyDown(Key.Up) && move != 3)
            {
                move = 1;

            }
            //Key Left
            if (GAME_ENGINE.GetKeyDown(Key.Left) && move != 0)
            {
                move = 2;
            }
            //Key Down
            if (GAME_ENGINE.GetKeyDown(Key.Down) && move != 1)
            {
                move = 3;
            }
            
            //Spawning a block yourself
            if (GAME_ENGINE.GetKeyDown(Key.A))
            {
                if (extrabreedte.Count > 1)
                {
                    extralengte.Add(extralengte.Last());
                    extrabreedte.Add(extrabreedte.Last());
                }
                else
                {
                    extralengte.Add(currentPosX2);
                    extrabreedte.Add(currentPosY2);
                }
            }

            slow++;
            //Movement Snake
            if (slow == 20)
            {
                slow = 0 + speed;
                if (pickY == currentPosY && pickX == currentPosX)
                {
                    if (extrabreedte.Count > 1)
                    {
                        extralengte.Add(extralengte.Last());
                        extrabreedte.Add(extrabreedte.Last());
                    }
                    else
                    {
                        extralengte.Add(currentPosX2);
                        extrabreedte.Add(currentPosY2);

                    }
                    if (speed <= 8)
                    {
                        speed++;
                    }
                    //spawning new apple and adding 100 to Score
                    pickY = randomGenerator.Next(0, GAME_ENGINE.GetScreenHeight()) / 64;
                    pickX = randomGenerator.Next(0, GAME_ENGINE.GetScreenWidth()) / 64;
                    pickX = pickX * 64;
                    pickY = pickY * 64;
                    score += 100;

                }
                //Movement Right
                if (move == 0)
                {
                    currentPosY2 = currentPosY;
                    currentPosX2 = currentPosX;
                    currentPosY += 64;

                }
                //Movement Up
                if (move == 1)
                {
                    currentPosX2 = currentPosX;

                    currentPosY2 = currentPosY;
                    currentPosX -= 64;

                }
                //Movement Left
                if (move == 2)
                {
                    currentPosY2 = currentPosY;
                    currentPosX2 = currentPosX;
                    currentPosY -= 64;

                }
                //Movement Down
                if (move == 3)
                {
                    currentPosX2 = currentPosX;

                    currentPosY2 = currentPosY;
                    currentPosX += 64;

                }
                //Out of screen when going Right
                if (currentPosY > GAME_ENGINE.GetScreenWidth() - 64)
                {
                    currentPosY = 0;
                }
                //Out of screen when going Down
                if (currentPosX > GAME_ENGINE.GetScreenHeight() - 64)
                {
                    currentPosX = 0;
                }
                //Out of screen when going Up
                if (currentPosX < 0)
                {
                    currentPosX = GAME_ENGINE.GetScreenHeight() - 64;
                }
                //Out of screen when going Left
                if (currentPosY < 0)
                {
                    currentPosY = GAME_ENGINE.GetScreenWidth() - 64;
                }
                //Losing when hitting yourself
                for (int i = 0; i < extralengte.Count; i++)
                {
                    if (currentPosX == extralengte[i] && currentPosY == extrabreedte[i])
                    {
                        //Score to 0
                        score -= score;
                        //Clear lists
                        extrabreedte.Clear();
                        extralengte.Clear();
                        //adding a part of the Snake so you won only get the head when respawning
                        extrabreedte.Add(currentPosX2);
                        extralengte.Add(currentPosY2);
                        //Going to main menu
                        main = false;
                        //Enabling button
                        Begin.SetActive(true);
                        //Stopping Music
                        GAME_ENGINE.StopAudio(BackgroundMusic);
                        //Setting movement to Right
                        move = 0;
                    }

                }
                //Draw every part of the snake thats in the list
                for (int i = 0; i < extralengte.Count; i++)
                {
                    //Part behind head
                    if (i + 1 < extrabreedte.Count)
                    {
                        extralengte[i] = extralengte[i + 1];
                        extrabreedte[i] = extrabreedte[i + 1];



                    }
                    //Part behind Tail
                    else
                    {
                        extralengte[i] = currentPosX2;
                        extrabreedte[i] = currentPosY2;
                    }

                }
            }
        }

        public override void Paint()
        {
            if (main == false)
            {
                //Drawing main Menu
                GAME_ENGINE.DrawBitmap(Logo, 20, 100);
                GAME_ENGINE.DrawString("Highscore: " + highscore + ".", 290, 440, 2000, 200);
                GAME_ENGINE.DrawString("Use arrow key's to Move.", 260, 300, 2000, 200);
                GAME_ENGINE.DrawString("Use num+ and num- to change volume of sounds.", 200, 320, 2000, 200);
            }
            if (main == true)
            {
                //Disabling button
                Begin.SetActive(false);
                //Drawing Snake head
                GAME_ENGINE.DrawBitmap(Snek, pickY, pickX, 256, 128, 64, 64);
                GAME_ENGINE.SetColor(0, 0, 0);
                GAME_ENGINE.FillRectangle(currentPosY, currentPosX, 64, 64);
                //Bitmaps for movement Head
                for (int i = extrabreedte.Count - 1; i >= 0; i--)
                {
                    GAME_ENGINE.FillRectangle(extrabreedte[i], extralengte[i], 64, 64);
                }
                if (move == 0)
                {
                    GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 64, 0, 64, 64);
                }
                if (move == 1)
                {
                    GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 0, 0, 64, 64);
                }
                if (move == 2)
                {
                    GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 192, 0, 64, 64);
                }
                if (move == 3)
                {
                    GAME_ENGINE.DrawBitmap(Snek, currentPosY, currentPosX, 128, 0, 64, 64);
                }
                //GAME_ENGINE.SetColor(0, 230, 210); Fancy collor Zhenja

                //Set volume
                if (GAME_ENGINE.GetKeyDown(Key.Add))
                {
                    if (volume < 100)
                    {
                        volume += 10;
                    }
                    BackgroundMusic.SetVolume(volume);

                }
                if (GAME_ENGINE.GetKeyDown(Key.Subtract))
                {
                    if (volume > 0)
                    {
                        volume -= 10;
                    }
                    BackgroundMusic.SetVolume(volume);
                }
                //Setting text color
                GAME_ENGINE.SetColor(220, 20, 60);
                //Drawing score and Highscore
                GAME_ENGINE.DrawString("score: " + score + ".", 0, 0, 200, 200);
                GAME_ENGINE.DrawString("Highscore: " + score + ".", 0, 20, 200, 200);
            }
            
        }
    }
}
