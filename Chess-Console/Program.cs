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

                table.PutPiece(new King(table, Color.White), new Position(0, 4));
                table.PutPiece(new Tower(table, Color.White), new Position(0, 0));
                table.PutPiece(new King(table, Color.White), new Position(9, 0));

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
