
//player classus is an Abstract base class for players. Each player has a name and symbol (x or o))
//Subclasses must implement GetMove() to return the column that the  player picked.

// Forces every subclass to implement their own version of GetMove().
namespace ConnectFour
{
    internal abstract class Player
    {
        public string Name { get; set; }
        public char Symbol { get; set; }

        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public abstract int GetMove();
    }
}