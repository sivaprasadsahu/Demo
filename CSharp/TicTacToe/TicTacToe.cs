using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            // Prompt user for board size
            Console.Write("Enter the size of the board: ");
            int boardSize = int.Parse(Console.ReadLine());

            // Initialize board
            char[,] board = new char[boardSize, boardSize];
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    board[row, col] = '-';
                }
            }

            // Game loop
            bool gameOver = false;
            char player = 'X';
            int moves = 0;

            while (!gameOver)
            {
                // Display board
                Console.WriteLine();
                for (int r = 0; r < boardSize; r++)
                {
                    for (int c = 0; c < boardSize; c++)
                    {
                        Console.Write(board[r, c] + " ");
                    }
                    Console.WriteLine();
                }

                // Prompt user for move
                Console.WriteLine("Player " + player + ", enter your move:");
                Console.Write("Row: ");
                int row = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Column: ");
                int col = int.Parse(Console.ReadLine()) - 1;

                // Check if move is valid
                if (board[row, col] == '-')
                {
                    board[row, col] = player;
                    moves++;

                    // Check if game is over
                    if (CheckWin(board, player, row, col))
                    {
                        Console.WriteLine("Player " + player + " wins!");
                        gameOver = true;
                    }
                    else if (moves == boardSize * boardSize)
                    {
                        Console.WriteLine("Draw!");
                        gameOver = true;
                    }
                    else
                    {
                        // Switch player
                        player = (player == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        // Check if the current move results in a win
        static bool CheckWin(char[,] board, char player, int row, int col)
        {
            int boardSize = board.GetLength(0);

            // Check row
            bool win = true;
            for (int c = 0; c < boardSize; c++)
            {
                if (board[row, c] != player)
                {
                    win = false;
                    break;
                }
            }
            if (win) return true;

            // Check column
            win = true;
            for (int r = 0; r < boardSize; r++)
            {
                if (board[r, col] != player)
                {
                    win = false;
                    break;
                }
            }
            if (win) return true;

            // Check diagonal
            win = true;
            if (row == col)
            {
                win = true;
                for (int i = 0; i < boardSize; i++)
                {
                    if (board[i, i] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true;
            }

            // Check anti-diagonal
            win = true;
            if (row + col == boardSize - 1)
            {
                win = true;
                for (int i = 0; i < boardSize; i++)
                {
                    if (board[i, boardSize - 1] != player)
                    {
                        win = false;
                        break;
                    }
                }
                if (win) return true; else return false;
            }
            return false;
        }
    }
}

