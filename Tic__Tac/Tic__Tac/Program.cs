using System;

namespace Tic__Tac
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Board = TicTacGame.CreateBoard();
            char Userletter =TicTacGame.Chooseuserletter();
            TicTacGame.Showboard(Board);
            TicTacGame.Getusermove(Board);
            TicTacGame.Makemove(Board, Usermove, Userletter);

        }
    }
}
