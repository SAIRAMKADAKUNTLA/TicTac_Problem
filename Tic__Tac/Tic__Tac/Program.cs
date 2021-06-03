using System;

namespace Tic__Tac
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Board = TicTacGame.CreateBoard();
            TicTacGame.Chooseuserletter();
            TicTacGame.Showboard(Board);
            TicTacGame.Toss();
            Console.WriteLine(" ");


        }
    }
}
