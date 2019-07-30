using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingChess
{
    class Player
    {
        private String name;
        private ArrayList moves;

        public void setName(String name)
        {
            this.name = name;
        }

        public Player()
        {
            moves = new ArrayList();
        }

        public void RecordStep(String step)
        {
            moves.Add(step);
        }

        public ArrayList getMoves()
        {
            return moves;
        }
    }
}
