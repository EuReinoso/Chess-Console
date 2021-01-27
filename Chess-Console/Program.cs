using System;
using table;
using chess;
namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            
            try
            {
                ChessGame match = new ChessGame();

                while (!match.endgame)
                {
                    try
                    {
                        Console.Clear();
                        Window.printMatch(match);

                       

                        Console.WriteLine();
                        Console.WriteLine("Select Piece: ");
                        Position piece = Window.readChessPosition().toPosition();
                        match.validPiecePos(piece);


                        bool[,] possiblePos = match.tab.piece(piece).possibleMoves();

                        Console.Clear();
                        Window.showTable(match.tab, possiblePos);

                        Console.WriteLine("Square: ");
                        Position square = Window.readChessPosition().toPosition();
                        match.validSquarePos(piece,square);

                        match.makeMove(piece, square);

                    }
                    catch(TableException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
              
                

               
            }
            catch (TableException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        
        
        }   

    }
}
