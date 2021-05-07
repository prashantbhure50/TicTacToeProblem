using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProblem
{
  public  class TicTacToe
    {
        public void Board(char[]board)
        {
            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }

        }
        public void DisplayBoard(char[] board)
        {
            Console.WriteLine("  " + board[1] + "  |  " + board[2] + "  |   " + board[3] + "   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + board[8] + "  |  " + board[7] + "  |   " + board[6] + "   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + board[7] + "  |  " + board[8] + "  |   " + board[9] + "   ");
            Console.WriteLine("     |     |      ");
        }
        public void PlayerPositionCheck(string pos)
        {
            pos=pos.ToUpper();
            if (pos == "X")
            {
                Console.WriteLine("Player Choice Is {0}",pos);
                Console.WriteLine("Computer Choice Is O");
            }
            else
            {
                Console.WriteLine("Computer Choice Is {0}", pos);
                Console.WriteLine("Player Choice Is O");
            }
        }
    }
}
