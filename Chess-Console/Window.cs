﻿using System;
using table;

namespace Chess_Console
{
    class Window
    {
        public static void showTable(Table tab)
        {
            for (int i = 0; i < tab.lines; i++)
            {
                for (int j = 0; j < tab.columns; j++)
                {
                    if (tab.piece(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}