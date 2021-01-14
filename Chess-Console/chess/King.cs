using table;

namespace chess
{
    class King : Piece
    {

        public King(Table tab, Color color) : base(tab, color)
        {
           
        }
        public override string ToString()
        {
            return "K";
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
            pos.setVal(position.lin -1, position.col);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }
            //northeast
            pos.setVal(position.lin - 1, position.col + 1);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            //right
            pos.setVal(position.lin, position.col + 1);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            //southeast
            pos.setVal(position.lin + 1, position.col + 1);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            //down
            pos.setVal(position.lin + 1, position.col);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            //southeast
            pos.setVal(position.lin + 1, position.col + 1);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            //south-west
            pos.setVal(position.lin + 1, position.col - 1);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            //left
            pos.setVal(position.lin , position.col - 1);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            //north-west
            pos.setVal(position.lin - 1, position.col - 1);
            if (table.isPositionValid(pos) && canMove(pos))
            {
                mat[pos.lin, pos.col] = true;
            }

            return mat;
        }
    }
}
