using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Tic_Tac_Toe
{
    
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.CreateBoard();
            string player = ticTacToe.PlayerStartingFirst();
            while (true)
            {
                Console.WriteLine(player + " plays");
                char playerLetter = ticTacToe.PlayerChoice();
                int location = ticTacToe.MoveToLocation();
                ticTacToe.MakeAMove(location, playerLetter);
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
