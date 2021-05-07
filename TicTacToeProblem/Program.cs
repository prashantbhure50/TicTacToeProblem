using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe tic = new TicTacToe();
            char[] board = new char[10];
            Console.WriteLine("Welcome to TicTacToe Game");
            tic.Board(board);
            tic.DisplayBoard(board);
            Console.WriteLine("Enter a Choice X or O");
            string pos = Console.ReadLine();
            tic.PlayerPositionCheck(pos);
        }
    }
}
