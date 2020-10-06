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
            string player = ticTacToe.PlayerChance();
            char playerLetter = ticTacToe.PlayerChoice();
            int location = ticTacToe.MoveToLocation();
            ticTacToe.MakeAMove(location, playerLetter);
            ticTacToe.ShowBoard();

        }
    }
}
