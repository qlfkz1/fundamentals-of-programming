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

        static string[,] generateBoard()
        {
            const int row = 3;
            const int col = 3;

            string[,] board = new string[row, col]
                {
                    {"[ ]", "[ ]", "[ ]"},
                    {"[ ]", "[ ]", "[ ]"},
                    {"[ ]", "[ ]", "[ ]"}
                };


            for (int i = 0; i < row; i++)
            {
                // Console.WriteLine(" _____ ");

                for (int v = 0; v < col; v++)
                {
                    Console.Write(board[i, v] + " ");
                }
                // Console.Write("|");
                Console.WriteLine();
            }

            return board;

        }

        static void chooseBoard(string[,] arr)
        {
            int player = 1;


            bool c1 = true;
            bool c2 = true;

            int row1 = 0;
            int col1 = 0;

            Console.WriteLine();
            while (c1)
            {
                Console.Write("Please enter a row (1 - 3): ");
                int row = Convert.ToInt32(Console.ReadLine());

                if (row < 0 || row > 3)
                {
                    Console.Write("Please re-enter (1 - 3): ");
                    row = Convert.ToInt32(Console.ReadLine());
                } else
                {
                    c1 = false;
                }

                row1 = row;
            }

            Console.WriteLine();
            while (c2)
            {
                Console.Write("Please enter a column (1 - 3): ");
                int col = Convert.ToInt32(Console.ReadLine());

                if (col < 0 || col > 3)
                {
                    Console.Write("Please re-enter (1 - 3): ");
                    col = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    c2 = false;
                }

                col1 = col;
            }

            if (player == 1)
            {
                arr[row1 - 1, col1 - 1] = "[X]";
            } else if (player == 2)
            {
                arr[row1 - 1, col1 - 1] = "[O]";
            }

            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                // Console.WriteLine(" _____ ");

                for (int v = 0; v < arr.GetLength(1); v++)
                {
                    Console.Write(arr[i, v] + " ");
                }
                // Console.Write("|");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Welcome();

            chooseBoard(generateBoard());
        }
    }
}