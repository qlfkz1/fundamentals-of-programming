using System;
using System.Threading;

namespace console_game
{
    class Program
    {

        static void Welcome()
        {
            Console.WriteLine("Welcome");
            Thread.Sleep(2000);
            Console.Clear();
        }


        static void Main(string[] args)
        {
            Welcome();
        }
    }
}
