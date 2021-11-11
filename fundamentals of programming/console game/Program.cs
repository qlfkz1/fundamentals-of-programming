using System;
using System.Threading;

namespace console_game
{
    class Program
    {

        static void Welcome()
        {
            Console.WriteLine("Welcome to Tic-tac-toe!");
            Thread.Sleep(1500);
            Console.Clear();
        }


        static void generateBoard()
        {
            const int row = 3;
            const int col = 3;

            string[,] board = new string[row, col]
                {
                    {"a", "b", "c"},
                    {"d", "e", "f"},
                    {"g", "h", "i"}
                };


            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(" _____ ");

                for (int v = 0; v < col; v++)
                {
                    Console.Write("|" + board[i, v]);
                }
                Console.Write("|");
                Console.WriteLine();
            }


            /* Console.WriteLine(" ________");
            Console.WriteLine("|  |  |  |");
            Console.WriteLine("|__|__|__|");
            Console.WriteLine("|  |  |  |");
            Console.WriteLine("|__|__|__|");
            Console.WriteLine("|  |  |  |");
            Console.WriteLine("|__|__|__|"); */
        }

        static void Main(string[] args)
        {
            Welcome();

            generateBoard();

        }
    }
}