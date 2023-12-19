namespace ConsoleApp1.fm;

using System;
using System.Collections.Generic;


public abstract class GamePrototype
{
    public string Title { get; set; }
    public double Price { get; set; }

    public abstract GamePrototype Clone();
}


public class Game : GamePrototype
{
    public string Genre { get; set; }

    public override GamePrototype Clone()
    {
        return new Game
        {
            Title = this.Title,
            Price = this.Price,
            Genre = this.Genre
        };
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Genre: {Genre}, Price: {Price:C}");
    }
}


public class GameStore
{
    private Dictionary<string, GamePrototype> games = new Dictionary<string, GamePrototype>();

    public void AddGamePrototype(string key, GamePrototype gamePrototype)
    {
        games[key] = gamePrototype;
    }

    public GamePrototype GetGameClone(string key)
    {
        if (games.ContainsKey(key))
        {
            return games[key].Clone();
        }
        else
        {
            throw new ArgumentException($"Key '{key}' not found.");
        }
    }
}

class Program
{
    static void Main()
    {
        
        var gameStore = new GameStore();

       
        gameStore.AddGamePrototype("action", new Game { Title = "Call of Duty", Genre = "Action", Price = 59.99 });
        gameStore.AddGamePrototype("rpg", new Game { Title = "The Witcher 3", Genre = "RPG", Price = 39.99 });

        
        var clonedActionGame = (Game)gameStore.GetGameClone("action");
        clonedActionGame.DisplayInfo();

        var clonedRpgGame = (Game)gameStore.GetGameClone("rpg");
        clonedRpgGame.DisplayInfo();
    }
}

