﻿using System;

namespace Tic__Tac
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Board = TicTacGame.CreateBoard();
            Console.WriteLine(Board);
        }
    }
}