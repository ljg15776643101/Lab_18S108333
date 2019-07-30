using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingChess
{
    class Piece
    {
        private Player belong;

        public Player getBelong()
        {
            return belong;
        }

        public void setBelong(Player belong)
        {
            this.belong = belong;
        }
    }
}
