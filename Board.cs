// Board class Represents the 6x7 game board. its main purpose is to take care of piece placement,
// display, and win/draw detection.

namespace ConnectFour
{
    internal class Board
    {
        private char[,] grid;
        private const int Rows = 6;
        private const int Cols = 7;

        public Board()
        {
            grid = new char[Rows, Cols];
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            for (int r = 0; r < Rows; r++)
                for (int c = 0; c < Cols; c++)
                    grid[r, c] = '#';
        }

        public char[,] GetGrid()
        {
            return grid;
        }

        public bool DropPiece(int col, char symbol)
        {
            if (col < 0 || col >= Cols) return false;

            for (int r = Rows - 1; r >= 0; r--)
            {
                if (grid[r, col] == '#')
                {
                    grid[r, col] = symbol;
                    return true;
                }
            }
            return false;
        }
        // IsFull returns true only when every cell in the top row has been taken.
        public bool IsFull()
        {
            for (int c = 0; c < Cols; c++)
                if (grid[0, c] == '#') return false;
            return true;
        }
        //below is the checkwin it is checking to see if there is any consecutive x's or o's in any directioin
        public bool CheckWin(char symbol)
        {
            // horizontal
            for (int r = 0; r < Rows; r++)
                for (int c = 0; c <= Cols - 4; c++)
                    if (grid[r, c] == symbol && grid[r, c + 1] == symbol && grid[r, c + 2] == symbol && grid[r, c + 3] == symbol)
                        return true;

            //vertical
            for (int r = 0; r <= Rows - 4; r++)
                for (int c = 0; c < Cols; c++)
                    if (grid[r, c] == symbol && grid[r + 1, c] == symbol && grid[r + 2, c] == symbol && grid[r + 3, c] == symbol)
                        return true;

            //diagonal down and right
            for (int r = 0; r <= Rows - 4; r++)
                for (int c = 0; c <= Cols - 4; c++)
                    if (grid[r, c] == symbol && grid[r + 1, c + 1] == symbol && grid[r + 2, c + 2] == symbol && grid[r + 3, c + 3] == symbol)
                        return true;

            //Diagonal down and left
            for (int r = 0; r <= Rows - 4; r++)
                for (int c = 3; c < Cols; c++)
                    if (grid[r, c] == symbol && grid[r + 1, c - 1] == symbol && grid[r + 2, c - 2] == symbol && grid[r + 3, c - 3] == symbol)
                        return true;

            return false;
        }
    }
}