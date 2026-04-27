//the HumanPlayer class Inherits from Player. Gets the player's move by reading keyboard input onn the console

// subtract 1 because player enters 1 to 7 but array is zero indexed (0 to 6)
namespace ConnectFour
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name, char symbol) : base(name, symbol)
        {
        }

        public override int GetMove()
        {
            Console.Write($"{Name}'s turn. Enter column (1-7): ");
            return int.Parse(Console.ReadLine()) - 1;
        }
    }
}