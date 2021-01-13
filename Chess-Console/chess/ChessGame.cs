using System;
using table;


namespace chess
{
    class ChessGame
    {
        public Table tab { get; set; }
        private int shift;
        private Color player;
        public bool endgame { get; private set; }
        
        public ChessGame()
        {
            tab = new Table(8, 8);
            shift = 1;
            player = Color.White;
            putPieces();
        }

        public void movePiece(Position initPos, Position finalPos)
        {
            Piece p = tab.removePiece(initPos);
            p.incrementMoves();
            Piece pCaptured = tab.removePiece(finalPos);
            tab.putPiece(p, finalPos);
        }

        private void putPieces()
        {
            //black
            tab.putPiece(new King(tab, Color.Black), new ChessPosition('e',8).toPosition());
            tab.putPiece(new Tower(tab, Color.Black), new ChessPosition('a', 8).toPosition());
            tab.putPiece(new Tower(tab, Color.Black), new ChessPosition('h',8).toPosition());

            //white
            tab.putPiece(new King(tab, Color.White), new ChessPosition('e', 1).toPosition());
            tab.putPiece(new Tower(tab, Color.White), new ChessPosition('a', 1).toPosition());
            tab.putPiece(new Tower(tab, Color.White), new ChessPosition('h', 1).toPosition());
        }
    }
}
