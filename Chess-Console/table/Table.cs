
namespace table
{
    class Table
    {
        public int lines { get; set; }
        public int columns { get; set; }

        private Piece[,] pieces;

        public Table(int lines, int columns)
        {
            this.lines = lines;
            this.columns = columns;
            pieces = new Piece[lines, columns];
        }

        public Piece piece(int lines, int columns)
        {
            return pieces[lines, columns];
        }

        public Piece piece(Position pos)
        {
            return piece(pos.lin, pos.col);
        }

        public bool isPiece(Position pos)
        {
            msgPosInvalid(pos);
            return piece(pos) != null;
        }

        public void putPiece(Piece p, Position pos)
        {
            if (isPiece(pos))
            {
                throw new TableException("Already have a Piece here!");
            }
            pieces[pos.lin, pos.col] = p;
            p.position = pos;
        }

        public bool isPositionValid(Position pos)
        {
            if (pos.lin <0 || pos.lin >= lines || pos.col <0 || pos.col >= columns)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void msgPosInvalid(Position pos)
        {
            if (!isPositionValid(pos))
            {
                throw new TableException("Invalid Position!");
            }
        }
    }
}
