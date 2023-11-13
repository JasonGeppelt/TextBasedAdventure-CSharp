namespace TextBasedAdventure;

class Scenario
{
    private string ScenarioText { get; set; }
    private string? Option1Text { get; set; }
    private string? Option2Text { get; set; }
    public Scenario? Option1Scenario { get; set; }
    public Scenario? Option2Scenario { get; set; }
    public Scenario? PreviousScenario { get; set; }

    public Scenario(
        string scenarioText, 
        string? option1Text = null, 
        Scenario? option1Scenario = null,
        string? option2Text = null, 
        Scenario? option2Scenario = null, 
        Scenario? previousScenario = null)
    {
        ScenarioText = scenarioText;
        Option1Text = option1Text;
        Option2Text = option2Text;
        Option1Scenario = option1Scenario;
        Option2Scenario = option2Scenario;
        PreviousScenario = previousScenario;
    }

    public bool Play()
    {
        Console.Clear();
        Console.WriteLine($"\n{ScenarioText}");

        while (Option1Scenario != null && Option2Scenario != null)
        {
            Console.WriteLine($"1. {Option1Text}");
            Console.WriteLine($"2. {Option2Text}");
            if (PreviousScenario != null) Console.WriteLine($"3. Go back to the previous scenario");
            
            Console.Write("Choose: ");
            string userInput = Console.ReadLine()?.ToLower() ?? "";

            switch (userInput)
            {
                case "1" when Option1Scenario != null:
                    return Option1Scenario.Play();
                case "2" when Option2Scenario != null:
                    return Option2Scenario.Play();
                case "3" when PreviousScenario != null:
                    return PreviousScenario.Play();
                default:
                    // Input error handling. If it is the starting scenario, no choice to go back one
                    Console.WriteLine($"\nInvalid input. Please enter {(PreviousScenario != null ? "1, 2, or 3" : "1 or 2")}.\n");
                    break;
            }
        }

        // User restarts, goes back, or quits
        Console.Write("Type 1 to play again, press enter to quit, or type 3 to go back to the previous scenario: ");
        string selection = Console.ReadLine()!;

        switch (selection.ToLower())
        {
            case "1":
                return true;
            case "3" when PreviousScenario != null:
                return PreviousScenario.Play();
            default:
                return false;
        }
    }
}
