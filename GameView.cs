// GameView class main job is to handle all the console output, and it Displays the board and game messages

namespace ConnectFour
{
    internal class GameView
    {
        public void DisplayBoard(char[,] grid)
        {
            Console.Clear();
            for (int r = 0; r < 6; r++)
            {
                Console.Write("| ");
                for (int c = 0; c < 7; c++)
                {
                    Console.Write(grid[r, c] + " ");
                }
                Console.WriteLine("|");
            }
            // Prints column numbers so players know which number to enter 
            Console.WriteLine("  1 2 3 4 5 6 7");
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}