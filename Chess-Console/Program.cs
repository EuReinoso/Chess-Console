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

              

                Window.showTable(match.tab);
            }
            catch (TableException e)
            {
                Console.WriteLine(e.Message);
            }

            ChessPosition pos = new ChessPosition('c', 5);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosition());

            Console.ReadLine();
        
        
        }   

    }
}
