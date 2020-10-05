using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe");
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.CreateBoard();
            char playerLetter = ticTacToe.PlayerChoice();
            ticTacToe.MoveToLocation(playerLetter);
            ticTacToe.ShowBoard();

        }
    }
}
