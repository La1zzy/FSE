namespace ConsoleApp1.fm;

using System;


public class Game
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }
    public string Platform { get; set; }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Platform: {Platform}");
    }
}


public interface IGameBuilder
{
    void BuildTitle();
    void BuildGenre();
    void BuildPrice();
    void BuildPlatform();
    Game GetGame();
}


public class ConcreteGameBuilder : IGameBuilder
{
    private Game game = new Game();

    public void BuildTitle()
    {
        game.Title = "Default Title";
    }

    public void BuildGenre()
    {
        game.Genre = "Default Genre";
    }

    public void BuildPrice()
    {
        game.Price = 0.00m;
    }

    public void BuildPlatform()
    {
        game.Platform = "Default Platform";
    }

    public Game GetGame()
    {
        return game;
    }
}


public class GameDirector
{
    private IGameBuilder gameBuilder;

    public GameDirector(IGameBuilder builder)
    {
        gameBuilder = builder;
    }

    public void ConstructGame()
    {
        gameBuilder.BuildTitle();
        gameBuilder.BuildGenre();
        gameBuilder.BuildPrice();
        gameBuilder.BuildPlatform();
    }
}

class Program
{
    static void Main()
    {
        
        IGameBuilder builder = new ConcreteGameBuilder();

        
        GameDirector director = new GameDirector(builder);

        
        director.ConstructGame();

        
        Game game = builder.GetGame();

        
        game.DisplayInfo();
    }
}

    
