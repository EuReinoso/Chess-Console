using System;
using table;


namespace chess
{
    class ChessGame
    {
        public Table tab { get; set; }
        public int turn { get; private set; }
        public Color player { get; private set; }
        public bool endgame { get; private set; }
        
        public ChessGame()
        {
            tab = new Table(8, 8);
            turn = 1;
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

        public void makeMove(Position piece, Position square)
        {
            movePiece(piece, square);
            turn++;
            changeColor();
        }

        public void validPiecePos(Position pos)
        {
            if (tab.piece(pos) == null)
            {
                throw new TableException("There are not pieces here!");
            }
            if (player != tab.piece(pos).color)
            {
                throw new TableException("This is not your piece!");
            }
            if (!tab.piece(pos).haveMoves())
            {
                throw new TableException("This piece are blocked");
            }

        }

        private void changeColor()
        {
            if (player == Color.White)
            {
                player = Color.Black;
            }
            else
            {
                player = Color.White;
            }
            
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
