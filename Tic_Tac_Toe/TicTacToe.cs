﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Tic_Tac_Toe
{
    class TicTacToe
    {
        char[] board;
        public TicTacToe()
        {
            board = new char[10];
        }
        public void CreateBoard()
        {          
            for( int i = 1; i<= 9; i++)
            {
                board[i] = ' ';
            }
        }
        
        public char PlayerChoice()
        {
            char choice;
            Console.WriteLine("Enter X or O");
            choice = Convert.ToChar(Console.ReadLine());
            if(choice == 'X' || choice == 'O')
            {               
                return choice;
            }
            
            PlayerChoice();
            return ' ';
        }
        public int MoveToLocation()
        {           
            Console.WriteLine("Enter Location index from 1 to 9");
            int location = Convert.ToInt32(Console.ReadLine());
            if (location < 1 || location > 9)
            {
                Console.WriteLine("Not valid index");
                MoveToLocation();
                
            }
            if (board[location] != ' ')
            {
                Console.WriteLine("Location already filled");
                MoveToLocation();
                
            }
            return location;
            
        }
        public void MakeAMove(int location,char letter)
        {
            board[location] = letter;
        }
        public void ShowBoard()
        {
            int i, j;
            for(i = 1; i < 10; i++)
            {
                if(i == 4 || i == 7)
                {
                    Console.WriteLine("\n");
                }
                Console.Write(board[i]+"|");
            }
        }
    }
}
