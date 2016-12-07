using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Player
    {
        private GameEngine m_GameEgnine;

        private Vector2f m_Pos;

        public Player()
        {
            m_GameEgnine = GameEngine.GetInstance();
        }

        public void Update()
        {
            m_Pos.Y = 718;
            if (m_GameEgnine.GetKey(Key.A))
            {
                m_Pos.X -= 400.0f * m_GameEgnine.GetDeltaTime();
            }
            if (m_GameEgnine.GetKey(Key.D))
            {
                m_Pos.X += 400.0f * m_GameEgnine.GetDeltaTime();
            }
        }

        public void Paint()
        {
            m_GameEgnine.SetColor(255, 255, 255);
            m_GameEgnine.FillRectangle(m_Pos.X, m_Pos.Y, 50, 50);

        }
    }
}
