using System;
using table;
namespace Chess_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(8,8);
          

            Window.showTable(table);
            

            Console.ReadLine();
        }
    }
}
