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
                    location = ticTacToe.GetComputerMove(computerLetter,playerLetter);
                    ticTacToe.MakeAMove(location, computerLetter);
                }               
                
                player = ticTacToe.PlayerChance(player);
            }

        }
    }
}
