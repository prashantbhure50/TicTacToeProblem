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
            Console.WriteLine("  " + board[4] + "  |  " + board[5] + "  |   " + board[6] + "   ");
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  " + board[7] + "  |  " + board[8] + "  |   " + board[9] + "   ");
            Console.WriteLine("     |     |      ");
        }
        //public void PlayerChoice(string playerchoice )
        //{
        //    playerchoice = playerchoice.ToUpper();
        //    if (playerchoice == "X")
        //    {
        //        Console.WriteLine("Player Choice Is {0}", playerchoice);
        //        Console.WriteLine("Computer Choice Is O");
                
        //    }
        //    else
        //    {
               
        //        Console.WriteLine("Player Choice Is O");
        //        Console.WriteLine("Computer Choice Is X");                
        //    }
        //}
        public void PositionHolder(char[] board,string choice,int position)
        {
            char symbol = ' ';
            if (choice.Equals("X"))
            {
                symbol = 'X';
                
            }
            else if (choice.Equals("O"))
            {
                symbol = 'O';
            }
            switch (position)
            {
                case 1:
                    board[1] = symbol;
                    break;
                case 2:
                    board[2] = symbol;
                    break;
                case 3:
                    board[3] = symbol;
                    break;
                case 4:
                    board[4] = symbol;
                    break;
                case 5:
                    board[5] = symbol;
                    break;
                case 6:
                    board[6] = symbol;
                    break;
                case 7:
                    board[7] = symbol;
                    break;
                case 8:
                    board[8] = symbol;
                    break;
                case 9:
                    board[9] = symbol;
                    break;
                default:
                    break;
            }

        }

        public  string checkWinner(char [] board)
        {
           : for (int a = 0; a < 8; a++)
            {
                String line = null;

                switch (a)
                {
                    case 0:
                        line = "" + board[1] + board[2] + board[3];
                        break;
                    case 1:
                        line = "" + board[4] + board[5] + board[6];
                        break;
                    case 2:
                        line = "" + board[7] + board[8] + board[9];
                        break;
                    case 3:
                        line = "" + board[1] + board[4] + board[7];
                        break;
                    case 4:
                        line = "" + board[2] + board[5] + board[8];
                        break;
                    case 5:
                        line = "" + board[3] + board[6] + board[9];
                        break;
                    case 6:
                        line = "" + board[1] + board[5] + board[9];
                        break;
                    case 7:
                        line = "" + board[3] + board[5] + board[7];
                        break;
                    default:
                        break;

                }
                if (line.Equals("XXX"))
                {
                    return "X";
                    Console.WriteLine("player Wins");
                    


                }
                else if (line.Equals("OOO"))
                {
                    Console.WriteLine("Computer wins");
                    return "O";
                    break;


                }

            }
            return "";


        }
    }
}
