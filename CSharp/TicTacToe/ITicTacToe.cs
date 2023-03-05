
namespace TicTacToe
{
    /// <summary>
    /// A TicTacToe game played on an imaginary n x n dimension board.
    /// </summary>
    public interface ITicTacToe
    {
        /// <summary>
        /// Place a piece on the game board
        /// </summary>
        /// <param name="row">row to place a piece</param>
        /// <param name="col">column to place a piece</param>
        /// <param name="player">the player (1 or 2) the piece is for</param>
        /// <returns>0 = no winner, 1 = player 1 won, 2 = player 2 won</returns>
        int PlacePiece(int row, int col, int player);
    }

}