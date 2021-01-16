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

                    Console.Clear();
                    Window.showTable(match.tab);

                    Console.WriteLine();
                    Console.WriteLine("Select Piece: ");
                    Position piece = Window.readChessPosition().toPosition();

                    
                    bool[,] possiblePos = match.tab.piece(piece).possibleMoves();

                    Console.Clear();
                    Window.showTable(match.tab,possiblePos);

                    Console.WriteLine("Square: ");
                    Position square = Window.readChessPosition().toPosition();

                    match.movePiece(piece, square);


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
