using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Enemy
    {
        private GameEngine m_GameEngine;

        private Vector2f m_Pos;

        private int m_Movement;

        public Enemy()
        {
            m_GameEngine = GameEngine.GetInstance();
            
        }

        public void Update()
        {

            for (int m_Movement = 0; m_Movement <= 4; m_Movement++)
            {
                
            }

        }

        public void Paint()
        {

            m_GameEngine.SetColor(255, 255, 255);
            m_GameEngine.FillRectangle(m_Pos.X, m_Pos.Y, 50, 50);

        }
    }
}
