using System;
using System.Collections.Generic;
using System.Text;

namespace Tic__Tac
{
 public class TicTacGame
    {
        ///UC-1 craeting the Board
        public static char[] CreateBoard() 
        {
            char[] Board = new char[10];
            for (int i=0; i<Board.Length; i++) 
            {
                Console.WriteLine(Board[i] = ' '); 
            }
            return Board;

            } 

        }

    }

