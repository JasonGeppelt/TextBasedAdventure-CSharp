namespace TextBasedAdventure;

class Program
{
    static void Main()
    {
        string playAgainInput; 
        
        // Game loop
        do
        {
            Game.Run();
            Console.Write("Type 1 to play again! Or enter anything else to quit: ");
            playAgainInput = Console.ReadLine()?.ToLower() ?? "1";

        } while (playAgainInput == "1");
        
        Console.WriteLine("\nThanks for playing! Goodbye!");
    }
}