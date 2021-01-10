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
                Table table = new Table(8, 8);

                ChessPosition pos = new ChessPosition('a', 1);

                Console.WriteLine(pos);
                Console.WriteLine(pos.toPosition());

                Window.showTable(table);

            }
            catch (TableException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
