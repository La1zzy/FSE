namespace ConsoleApp1.fm;

using System;

public class GameStore
{
    private static GameStore instance;

    

    private GameStore()
    {
       
    }

    public static GameStore Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameStore();
                
            }
            return instance;
        }
    }

    
    public void PurchaseGame(string gameTitle, string username)
    {
        Console.WriteLine($"{username} purchased {gameTitle} from the game store.");
        
    }
}

class Program
{
    static void Main()
    {
        
        GameStore store = GameStore.Instance;

        
        store.PurchaseGame("Cyberpunk 2077", "JohnDoe");
        store.PurchaseGame("The Witcher 3", "JaneSmith");
    }
}


    
