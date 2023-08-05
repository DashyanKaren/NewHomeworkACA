using System;

namespace TicTakWithConsole
{


    internal class Program
    {


        private static int ROWS = 3;
        private static int COLUMNS = 3;
        private static char[,] board = new char[ROWS, COLUMNS];
        private static bool Player=true;
        private static void BoardEmpty()
        {
            for (int r = 0; r < ROWS; r++)
            {
                for (int c = 0; c < COLUMNS; c++)
                {
                    board[r, c] = ' ';
                }
            }
        }
        private static void PrintBoard()
        {
            
            for (int r = 0; r < ROWS; r++)
            {
                Console.WriteLine("-------------");
                for (int c = 0; c < COLUMNS; c++)
                {
                    Console.Write("| ");
                    Console.Write(board[r, c]);
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-------------");
        }
        private static bool FillCell(int row, int col) 
        {
            if (row>=0 && col>=0 && row<ROWS && col<COLUMNS && board[row, col]==' ' )
            {
                if (Player)
                {
                    board[row, col] = 'X';
                    Player = false;
                }
                else
                {
                    board[row, col] = 'O';
                    Player= true;
                }
                return true;
            }
            return false;
        }
        private static bool Check()
        {
            for (int i = 0; i < ROWS; i++)
            {
                if (board[i, 1] == board[i, 2] && board[i, 1] == board[i, 0] && board[i, 0] != ' ')
                {
                    return true;
                }
                else return false;
            }
            for (int i = 0; i < COLUMNS; i++)
            {
                if (board[1, i] == board[2, i] && board[1, i] == board[0, i] && board[0, i] != ' ')
                {
                    return true;
                }
                else return false;
            }
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                return true;
            }
            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2] && board[2, 0] != ' ')
            {
                return true;
            }
            return false;

        }

        static void Main(string[] args)
        {
           BoardEmpty();
           PrintBoard();
            

            while (true)
            {
                Console.WriteLine(  "please choose a cell to input (Row, Column) ");
                Console.WriteLine(  "Please remember that board starts with (0,0) Index ");
                int row=Convert.ToInt32(Console.ReadLine());
                int col=Convert.ToInt32(Console.ReadLine());
                FillCell(row, col);
                PrintBoard();
                Check();
                if (Check())
                {
                    if (Player)
                    {
                        Console.WriteLine(  "Player X wins");
                    }
                    else
                    {
                        Console.WriteLine(  "Player O wins");
                    }
                }
                

            }
            




        }
    }
}
