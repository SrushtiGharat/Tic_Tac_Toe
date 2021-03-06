﻿using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tic_Tac_Toe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                int location = 0;
                int status = 0;

                Console.WriteLine("Welcome to Tic-Tac-Toe");
                TicTacToe ticTacToe = new TicTacToe();
                ticTacToe.CreateBoard();
                char playerLetter = ticTacToe.PlayerChoice();
                char computerLetter = ticTacToe.getComputerLetter(playerLetter);
                string player = ticTacToe.PlayerStartingFirst();
                while (true)
                {
                    Console.WriteLine(player + " plays");
                    if (player == "USER")
                    {
                        location = ticTacToe.MoveToLocation();
                        ticTacToe.MakeAMove(location, playerLetter);
                        status = ticTacToe.getGameStatus(playerLetter);
                    }
                    if (player == "COMPUTER")
                    {
                        location = ticTacToe.GetComputerMove(computerLetter, playerLetter);
                        ticTacToe.MakeAMove(location, computerLetter);
                        status = ticTacToe.getGameStatus(computerLetter);
                    }
                    ticTacToe.ShowBoard();
                    if (status == 0)
                    {
                        Console.WriteLine(player + " Has Won The Game");
                        break;
                    }
                    if (status == 1)
                    {
                        Console.WriteLine("It's a tie");
                        break;
                    }
                    player = ticTacToe.PlayerChance(player);
                }
                Console.WriteLine("Do you want to play again?");
                string answer = Console.ReadLine();
                if (answer.Equals("No"))
                    flag = false;              
            }

        }
    }
}
