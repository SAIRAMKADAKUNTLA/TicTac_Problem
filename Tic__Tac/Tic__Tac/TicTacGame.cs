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
        //UC2-chooseuserletter
        public static char Chooseuserletter() 
        {
            Console.WriteLine("Enter your letter");
            char Userletter = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(Userletter);
        }
        //UC3-show board

        public static void Showboard(char[] Board)
        {
            Console.WriteLine(" | " + Board[1] + " | " + Board[2] + " | " + Board[3] + " | ");
            Console.WriteLine(" | " + Board[4] + " | " + Board[5] + " | " + Board[6] + " | ");
            Console.WriteLine(" | " + Board[7] + " | " + Board[8] + " | " + Board[9] + " | ");
        }

        }

    }

