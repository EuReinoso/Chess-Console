using System.Collections.Generic;
using table;


namespace chess
{
    class ChessGame
    {
        public Table tab { get; set; }
        public int turn { get; private set; }
        public Color player { get; private set; }
        public bool endgame { get; private set; }
        private HashSet<Piece> pieces;
        private HashSet<Piece> captured;
        public ChessGame()
        {
            tab = new Table(8, 8);
            turn = 1;
            player = Color.White;
            endgame = false;
            pieces = new HashSet<Piece>();
            captured = new HashSet<Piece>();
            putPieces();
        }

        public void movePiece(Position initPos, Position finalPos)
        {
            Piece p = tab.removePiece(initPos);
            p.incrementMoves();
            Piece pCaptured = tab.removePiece(finalPos);
            tab.putPiece(p, finalPos);
            if (pCaptured != null)
            {
                captured.Add(pCaptured);
            }
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

        public void validSquarePos(Position piece, Position square)
        {
            if (!tab.piece(piece).canMoveTo(square))
            {
                throw new TableException("Invalid square!");
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

        public HashSet<Piece> capturedPieces(Color c)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach (Piece x in captured)
            {
                if (x.color == c)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }


        public HashSet<Piece> piecesOnBoard(Color c)
        {
            HashSet<Piece> aux = new HashSet<Piece>();
            foreach(Piece x in pieces)
            {
                if (x.color == c)
                {
                    aux.Add(x);
                }
            }

            aux.ExceptWith(capturedPieces(c));
            return aux;
        }

        public void putNewPiece(char col, int lin, Piece p)
        {
            tab.putPiece(p, new ChessPosition(col, lin).toPosition());
            pieces.Add(p);
        }

        private void putPieces()
        {
            //black
            putNewPiece('e', 8, new King(tab, Color.Black));
            putNewPiece('a', 8, new Tower(tab, Color.Black));
            putNewPiece('h', 8, new Tower(tab, Color.Black));

            //white
            putNewPiece('e', 1, new King(tab, Color.White));
            putNewPiece('a', 1, new Tower(tab, Color.White));
            putNewPiece('h', 1, new Tower(tab, Color.White));
        }
    }
}
