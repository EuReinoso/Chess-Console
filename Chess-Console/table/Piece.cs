namespace table
{
    class Piece
    {
        public Color color { get; set; }
        public Position position { get; set; }
        public  int qMoves { get; set; }
        public Table table { get; set; }

        public Piece(Position position, Table table, Color color) 
        {
            this.position = position;
            this.table = table;
            this.color = color;
            this.qMoves = 0;
        }
    }
}
