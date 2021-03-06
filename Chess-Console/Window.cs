﻿using System;
using table;
using chess;
using System.Collections.Generic;

namespace Chess_Console
{
    class Window
    {
        public  static void printMatch(ChessGame match)
        {
            showTable(match.tab);

            Console.WriteLine();
            printCapturedPieces(match);
            Console.WriteLine("Turn: " + match.turn);
            Console.WriteLine();
            Console.WriteLine("Waiting " + match.player + " move!");
        }

        public static void printCapturedPieces(ChessGame match)
        {
            Console.WriteLine("Captured Pieces");
            Console.Write("White: ");
            printSet(match.capturedPieces(Color.White));
            Console.WriteLine();
            Console.Write("Black: ");
            printSet(match.capturedPieces(Color.Black));
            Console.WriteLine();
            
        }

        public static void printSet(HashSet<Piece> set)
        {
            Console.Write("[");
            foreach(Piece x in set)
            {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void showTable(Table tab)
        {
            int squareColor = new int();
            squareColor = 0;

            ConsoleColor backgroundMain = Console.BackgroundColor;

            ConsoleColor background1 = ConsoleColor.Black;
            ConsoleColor background2 = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.lines; i++)
            {

                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.columns; j++)
                {
                    if (squareColor % 2 == 0)
                    {
                        Console.BackgroundColor = background2;
                    }
                    else
                    {
                        Console.BackgroundColor = background1;
                    }
                    
                    squareColor++;
                    printPiece(tab.piece(i, j));
                    Console.BackgroundColor = backgroundMain;

                }
                squareColor++;
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = backgroundMain;
        }

        public static void showTable(Table tab, bool [,]possiblePos)
        {
            int squareColor = new int();
            squareColor = 0;

            ConsoleColor backgroundMain = Console.BackgroundColor;
            ConsoleColor backgroundMoves = ConsoleColor.DarkGreen;

            ConsoleColor background1 = ConsoleColor.Black;
            ConsoleColor background2 = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.lines; i++)
            {
                
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.columns; j++)
                {

                    if (possiblePos[i, j] == true)
                    {
                        Console.BackgroundColor = backgroundMoves;
                    }
                    else
                    {
                        if (squareColor % 2 == 0)
                        {
                            Console.BackgroundColor = background2;
                        }
                        else
                        {
                            Console.BackgroundColor = background1;
                        }
                    }
                    squareColor++;
                    printPiece(tab.piece(i, j));
                    Console.BackgroundColor = backgroundMain;

                }
                squareColor++;
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = backgroundMain;
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
            if (p == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (p.color == Color.White)
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(p);
                    Console.ForegroundColor = aux;
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(p);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

    }
}
