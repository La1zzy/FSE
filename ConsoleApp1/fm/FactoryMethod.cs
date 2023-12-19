namespace ConsoleApp1.fm;
// Продукт - ігра
public interface IGame
{
    void Play();
}

// Конкретний продукт - конкретна гра
public class ActionGame : IGame
{
    public void Play()
    {
        Console.WriteLine("Граю в екшен-гру");
    }
}

// Конкретний продукт - інша гра
public class StrategyGame : IGame
{
    public void Play()
    {
        Console.WriteLine("Граю в стратегічну гру");
    }
}

// Фабрика - інтерфейс, який визначає метод створення продукту
public interface IGameFactory
{
    IGame CreateGame();
}

// Конкретна фабрика для екшен-ігор
public class ActionGameFactory : IGameFactory
{
    public IGame CreateGame()
    {
        return new ActionGame();
    }
}

// Конкретна фабрика для стратегічних ігор
public class StrategyGameFactory : IGameFactory
{
    public IGame CreateGame()
    {
        return new StrategyGame();
    }
}

// Клієнтський код, який використовує фабрику
class Program
{
    static void Main(string[] args)
    {
        // Клієнт використовує фабрику для створення конкретного продукту (гри)
        IGameFactory actionGameFactory = new ActionGameFactory();
        IGame actionGame = actionGameFactory.CreateGame();
        actionGame.Play();

        IGameFactory strategyGameFactory = new StrategyGameFactory();
        IGame strategyGame = strategyGameFactory.CreateGame();
        strategyGame.Play();
    }
}

