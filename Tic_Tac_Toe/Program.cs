﻿using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            TicTacToe ticTacToe = new TicTacToe();
            char playerLetter = ticTacToe.PlayerChoice();
            char compuerLetter = ticTacToe.PlayerChoice();


        }
    }
}
