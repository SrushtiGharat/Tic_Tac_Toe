﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class TicTacToe
    {
        public void CreateBoard()
        {
            char[] board = new char[10];
            for( int i = 1; i<= 9; i++)
            {
                board[i] = ' ';
            }
        }
        
        public char PlayerChoice()
        {
            Console.WriteLine("Enter X or O");
            char choice = Convert.ToChar(Console.ReadLine());
            return choice;
        }
    }
}
