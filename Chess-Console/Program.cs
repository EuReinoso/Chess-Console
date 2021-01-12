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

                //black
                table.putPiece(new King(table, Color.Black) , new Position (0, 4));
                table.putPiece(new Tower(table, Color.Black), new Position(0, 0));
                table.putPiece(new Tower(table, Color.Black), new Position(0, 7));

                //white
                table.putPiece(new King(table, Color.White), new Position(7, 4));
                table.putPiece(new Tower(table, Color.White), new Position(7, 7));
                table.putPiece(new Tower(table, Color.White), new Position(7, 0));

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
