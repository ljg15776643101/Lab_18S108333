using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingChess
{
    class Board
    {
        protected Position[][] positions;

        public Position[][] getPosition()
        {
            return positions;
        }
    }
}

enum BoardType
{
    CHESS, GO
}