using System;
using System.Threading;

namespace console_game
{
    class Program
    {

        static void Welcome()
        {
            Console.WriteLine("Welcome to Tic-tac-toe!");
            Thread.Sleep(2000);
            Console.Clear();
        }


        static void generateBoard()
        {
            int row = 5;
            int col = 5;

            string[,] board = new string[row, col];

            for (int i = 0; i < 5; i++)
            {
                for (int v = 0; v < 5; v++)
                {
                    board[i, v] = " 1";
                    Console.Write(board[i, v]);
                }

            }
        }

        static void Main(string[] args)
        {
            Welcome();

            generateBoard();
            

        }
    }
}
