using table;

namespace chess
{
    class Tower : Piece
    {

        public Tower(Table tab, Color color) : base(tab, color)
        {

        }

        public override string ToString()
        {
            return "R";
        }

        private bool canMove(Position pos)
        {
            Piece p = table.piece(pos);
            return p == null || p.color != color;
        }

        public override bool[,] possibleMoves()
        {
            bool[,] mat = new bool[table.lines, table.columns];

            Position pos = new Position(0, 0);

            //up
            pos.setVal(position.lin - 1, position.col);
            while (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;

                if (table.piece(pos) != null && table.piece(pos).color != color)
                {
                    break;
                }
                pos.lin = pos.lin - 1;
            }

            //right
            pos.setVal(position.lin, position.col + 1);
            while (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;

                if (table.piece(pos) != null && table.piece(pos).color != color)
                {
                    break;
                }
                pos.col = pos.col + 1;
            }

            //down
            pos.setVal(position.lin + 1 , position.col);
            while (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;

                if (table.piece(pos) != null && table.piece(pos).color != color)
                {
                    break;
                }
                pos.lin = pos.lin + 1;
            }

            //left
            pos.setVal(position.lin, position.col - 1);
            while (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;

                if (table.piece(pos) != null && table.piece(pos).color != color)
                {
                    break;
                }
                pos.col = pos.col - 1;
            }

            return mat;
        }
    }
}