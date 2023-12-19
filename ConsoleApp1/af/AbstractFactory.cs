namespace ConsoleApp1.fm;


using System;

// Абстрактні продукти
interface IGame
{
    string Name { get; }
    void Play();
}

class ActionGame : IGame
{
    public string Name => "Action Game";

    public void Play()
    {
        Console.WriteLine("Playing action game...");
    }
}

class StrategyGame : IGame
{
    public string Name => "Strategy Game";

    public void Play()
    {
        Console.WriteLine("Playing strategy game...");
    }
}

// Абстрактна фабрика
interface IGameFactory
{
    IGame CreateGame();
}

// Фабрика для створення екшн ігор
class ActionGameFactory : IGameFactory
{
    public IGame CreateGame()
    {
        return new ActionGame();
    }
}

// Фабрика для створення стратегічних ігор
class StrategyGameFactory : IGameFactory
{
    public IGame CreateGame()
    {
        return new StrategyGame();
    }
}

// Клієнтський код
class Program
{
    static void Main(string[] args)
    {
        // Вибираємо фабрику для екшн ігор
        IGameFactory actionGameFactory = new ActionGameFactory();
        IGame actionGame = actionGameFactory.CreateGame();
        Console.WriteLine($"Created {actionGame.Name}");
        actionGame.Play();

        // Вибираємо фабрику для стратегічних ігор
        IGameFactory strategyGameFactory = new StrategyGameFactory();
        IGame strategyGame = strategyGameFactory.CreateGame();
        Console.WriteLine($"Created {strategyGame.Name}");
        strategyGame.Play();
    }
}
