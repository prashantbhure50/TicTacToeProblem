using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe tic = new TicTacToe();
            char[] board = new char[10];
            Random random = new Random();
            Console.WriteLine("Welcome to TicTacToe Game");
            tic.Board(board);
            tic.DisplayBoard(board);
            string Playerchoice = "X";
            string computerChoice = "O";
          
          


            Console.WriteLine("Enter a Choice Between  1-9");

            while (true)
            {
                Console.WriteLine("   player Turn         ");
                int position = Convert.ToInt32(Console.ReadLine());              
                tic.PositionHolder(board, Playerchoice, position);
                tic.DisplayBoard(board);
                tic.checkWinner(board);
                Console.WriteLine("   Computer Turn       ");
                int computerTurn = random.Next(1,10);
                tic.PositionHolder(board, computerChoice, computerTurn);
                tic.DisplayBoard(board);
                tic.checkWinner(board);
            }


        }
    }
}
