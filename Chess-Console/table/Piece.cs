namespace table
{
    abstract class Piece
    {
        public Color color { get; set; }
        public Position position { get; set; }
        public  int qMoves { get; set; }
        public Table table { get; set; }

        public Piece(Table table, Color color) 
        {
            this.position = null;
            this.table = table;
            this.color = color;
            this.qMoves = 0;
        }

        public void incrementMoves()
        {
            qMoves++;
        }

        public bool haveMoves()
        {
            bool[,] mat = possibleMoves();
            
            for ( int i = 0; i < table.lines; i++)
            {
                for (int j = 0; j < table.columns; j++)
                {
                    if (mat[i,j]) 
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool canMoveTo(Position pos)
        {
            return possibleMoves()[pos.lin, pos.col];
        }



        public abstract bool[,] possibleMoves();
           
        
    }
}
