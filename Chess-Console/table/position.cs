using System;
using System.Collections.Generic;
using System.Text;

namespace Chess_Console.table
{
    class Position
    {
        public int lin { get; set; }
        public int col { get; set; }

        public Position(int lin, int col)
        {
            this.lin = lin;
            this.col = col;
        }
    }
}
