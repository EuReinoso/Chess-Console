using System;
using table;

namespace chess
{
    class ChessPosition
    {
        public char column { get; set; }
        public int line { get; set; }

        public ChessPosition(char column, int line)
        {
            this.column = column;
            this.line = line;
        }

        public Position toPosition()
        {
            int lin = 8 - line;
            int col = convertCol();
            return new Position(lin, col);
        }

        public int convertCol()
        {
            int num = column == 'a' ? 0 :
                    column == 'A' ? 0 :
                    column == 'b' ? 1 :
                    column == 'B' ? 1 :
                    column == 'c' ? 2 :
                    column == 'C' ? 2 :
                    column == 'd' ? 3 :
                    column == 'D' ? 3 :
                    column == 'e' ? 4 :
                    column == 'E' ? 4 :
                    column == 'f' ? 5 :
                    column == 'F' ? 5 :
                    column == 'g' ? 6 :
                    column == 'G' ? 6 :
                    column == 'h' ? 7 :
                    column == 'H' ? 7 : -1;
            return num;
        }
       

        public override string ToString()
        {
            return "" + column + line;
        }
    }
}
