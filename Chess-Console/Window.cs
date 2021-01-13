using System;
using table;
using chess;

namespace Chess_Console
{
    class Window
    {
        public static void showTable(Table tab)
        {
            for (int i = 0; i < tab.lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.columns; j++)
                {
                    if (tab.piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        printPiece(tab.piece(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char col = s[0];
            int lin = int.Parse(s[1] + "");
            return new ChessPosition(col, lin);
        }

        public static void printPiece(Piece p)
        {
            if (p.color == Color.White) 
            {
                Console.Write(p);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(p);
                Console.ForegroundColor = aux;
            }
        }
    }
}
