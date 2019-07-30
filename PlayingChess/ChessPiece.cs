using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingChess
{
    class ChessPiece:Piece
    {
        private ChessPieceType type;

        public ChessPieceType getType()
        {
            return type;
        }

        public void setType(ChessPieceType type)
        {
            this.type = type;
        }
    }
}
enum ChessPieceType
{
    KING, QUEEN, ROCK, BISHOP, KNIGHT, PAWN, OTHER
}