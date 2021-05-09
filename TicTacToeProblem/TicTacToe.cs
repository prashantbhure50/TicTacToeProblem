using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProblem
{
  public  class TicTacToe
    {
       
        public void DisplayBoard(char[] board)
        {
            Console.WriteLine("  " + board[1] + "  |  " + board[2] + "  |   " + board[3] + "   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + board[4] + "  |  " + board[5] + "  |   " + board[6] + "   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + board[7] + "  |  " + board[8] + "  |   " + board[9] + "   ");
            Console.WriteLine("     |     |      ");
        }
       
        public int PositionHolder(char[] board,int player,int position)
        {
            try
            {
                if (board[position] != 'X' && board[position] != 'O')
                {
                    if (player % 2 == 0) 
                    {
                        board[position] = 'O';
                        return 1;
                    }
                    else
                    {
                        board[position] = 'X';
                        return 0;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", position, board[position]);
                }
            }
            catch (Exception e)
            { }
            return -1;
        }
        public  int CheckWinner(char[] gameBoard)
        {
            for (int a = 0; a < 8; a++)
            {
                String line = null;

                switch (a)
                {
                    case 0:
                        line = "" + gameBoard[1] + gameBoard[ 2] + gameBoard[3];
                        break;
                    case 1:
                        line = "" + gameBoard[4] + gameBoard[5] + gameBoard[6];
                        break;
                    case 2:
                        line = "" + gameBoard[7] + gameBoard[8] + gameBoard[9];
                        break;
                    case 3:
                        line = "" + gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;
                    case 4:
                        line = "" + gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                    case 5:
                        line = "" + gameBoard[3] + gameBoard[6] + gameBoard[9];
                        break;
                    case 6:
                        line = "" + gameBoard[1] + gameBoard[5] + gameBoard[9];
                        break;
                    case 7:
                        line = "" + gameBoard[3] + gameBoard[5] + gameBoard[7];
                        break;
                    default:
                        break;

                }
                if (line.Equals("XXX"))
                {
                    return 1;
                }
                else if (line.Equals("OOO"))
                {
                    return -1;
                }

            }
            return 2;
        }
    }
    }

