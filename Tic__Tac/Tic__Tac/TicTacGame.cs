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
            for (int i = 0; i < Board.Length; i++)
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
        //UC4-UserMove
        public static int Getusermove(char[] Board)
        {
            int[] ValidCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("your next move? (1-9)");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(ValidCells, element => element == index) != 0 && isSpaceFree(Board, index))
                    return index;
            }
        }
        public static bool isSpaceFree(char[] board, int index)
        {
            return board[index] == '_';
        }
        //UC5-check for freespace
        public static void Makemove(char[] Board, int index, char Letter)
        {
            Boolean spacefree = isSpaceFree(Board, index);
            if (spacefree) Board[index] = Letter;

        }

    }
}

