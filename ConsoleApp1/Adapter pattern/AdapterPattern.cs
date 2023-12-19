namespace ConsoleApp1.fm;

public interface IGame
{
    string GetName();
    decimal GetPrice();
}


public class ComputerGame : IGame
{
    private string name;
    private decimal price;

    public ComputerGame(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName()
    {
        return name;
    }

    public decimal GetPrice()
    {
        return price;
    }
}


public interface IOnlineStore
{
    string GetProductName();
    double GetProductPrice();
}


public class GameAdapter : IOnlineStore
{
    private IGame game;

    public GameAdapter(IGame game)
    {
        this.game = game;
    }

    public string GetProductName()
    {
        return game.GetName();
    }

    public double GetProductPrice()
    {
        
        return Convert.ToDouble(game.GetPrice());
    }
}

class Program
{
    static void Main()
    {
        
        IGame computerGame = new ComputerGame("Game Title", 49.99m);

        
        IOnlineStore onlineStoreAdapter = new GameAdapter(computerGame);

      
        Console.WriteLine("Product Name: " + onlineStoreAdapter.GetProductName());
        Console.WriteLine("Product Price: $" + onlineStoreAdapter.GetProductPrice());
    }
}
