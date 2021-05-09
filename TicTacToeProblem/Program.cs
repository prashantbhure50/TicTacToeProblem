using System;

namespace TicTacToeProblem
{
    class Program
    {
        static int flag = 0;
        static int player = 1;
        static void Main(string[] args)
        {
            TicTacToe tic = new TicTacToe();
            char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            Console.WriteLine("Welcome to TicTacToe Game");
            Console.Clear();
            tic.DisplayBoard(board);         
            while (flag != 1 && flag != -1)
            {
                if (player % 2 == 0)
                    Console.WriteLine("Player O Chance");
                else
                    Console.WriteLine("Player X Chance");

                int position1 = Convert.ToInt32(Console.ReadLine());
                player= tic.PositionHolder(board, player, position1);
                Console.Clear();
                tic.DisplayBoard(board);                
                flag = tic.CheckWinner(board);             
            }

            if (flag == 1)
            {
                Console.WriteLine("************Player 1 is winner*************");
            }
            else if (flag == -1)
            {
                Console.WriteLine("*************Player 2 is Winner***********");
            }
            else if(flag ==2)
            {
                Console.WriteLine("Game Draw");
            }

            Console.ReadKey();
        }
    }

}  

