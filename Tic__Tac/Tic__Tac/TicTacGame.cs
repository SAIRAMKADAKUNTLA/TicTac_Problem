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
        public static char Chooseuserletter() 
        {
            Console.WriteLine("Enter your letter");
            char Userletter = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(Userletter);
        }

        }

    }

