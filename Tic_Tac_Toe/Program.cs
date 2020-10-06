using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tic_Tac_Toe
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int location = 0;
            
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
                }
                if(player == "COMPUTER")
                {
                    location = ticTacToe.GetComputerMove(computerLetter);
                    ticTacToe.MakeAMove(location, computerLetter);
                }               
                ticTacToe.ShowBoard();
                if (ticTacToe.CheckWinner(playerLetter) == true)
                {
                    Console.WriteLine(player + " Has Won");
                    break;
                }
                if (ticTacToe.CheckDraw())
                {
                    Console.WriteLine("It's a tie");
                    break;
                }
                player = ticTacToe.PlayerChance(player);
            }

        }
    }
}
