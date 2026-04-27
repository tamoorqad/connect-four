// GameController classs job is to Manages the game loop. switch turns between players + updates the board,
// + checks for win or draw conditions.

namespace ConnectFour
{
    internal class GameController
    {
        private Board board;
        private Player[] players;
        private GameView view;
        private int currentPlayerIndex;

        public GameController()
        {
            board = new Board();
            view = new GameView();
            players = new Player[2];
            players[0] = new HumanPlayer("Player 1", 'X');
            players[1] = new HumanPlayer("Player 2", 'O');
            currentPlayerIndex = 0;
        }

        public void StartGame()
        {
            bool gameOver = false;

            while (!gameOver)
            {
                view.DisplayBoard(board.GetGrid());
                Player current = players[currentPlayerIndex];
                int col = current.GetMove();

                if (board.DropPiece(col, current.Symbol))
                {
                    if (board.CheckWin(current.Symbol))
                    {
                        view.DisplayBoard(board.GetGrid());
                        view.DisplayMessage($"{current.Name} wins!");
                        gameOver = true;
                    }
                    else if (board.IsFull())
                    {
                        view.DisplayBoard(board.GetGrid());
                        view.DisplayMessage("It's a draw!");
                        gameOver = true;
                    }
                    else
                    {  
                     // Switches between player 0 and player 1 using modulo 2
                        currentPlayerIndex = (currentPlayerIndex + 1) % 2;
                    }
                }
                else
                {
                    view.DisplayMessage("Column is full. Try again.");
                }
            }

            view.DisplayMessage("Restart? Yes(1) No(0): ");
            string input = Console.ReadLine();
            if (input == "1")
            {
                board = new Board();
                currentPlayerIndex = 0;
                StartGame();
            }
        }
    }
}