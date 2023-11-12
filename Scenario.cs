namespace TextBasedAdventure;

class Scenario
{
    private string ScenarioText { get; set; }
    public Scenario? Option1 { get; set; }
    public Scenario? Option2 { get; set; }
    private string? Option1Text { get; set; }
    private string? Option2Text { get; set; }

    public Scenario(string scenarioText, string? option1Text = null, Scenario? option1 = null,
        string? option2Text = null, Scenario? option2 = null)
    {
        ScenarioText = scenarioText;
        Option1 = option1;
        Option2 = option2;
        Option1Text = option1Text;
        Option2Text = option2Text;
    }

    public void Play()
    {
        Console.Clear();
        Console.WriteLine($"\n{ScenarioText}");

        while (Option1 != null! && Option2 != null!)
        {
            Console.WriteLine($"1. {Option1Text}");
            Console.WriteLine($"2. {Option2Text}");

            Console.Write("Choose: ");
            string userInput = Console.ReadLine()?.ToLower() ?? "";

            if (userInput == "1")
            {
                Option1.Play();
                return;
            }

            if (userInput == "2")
            {
                Option2.Play();
                return;
            }

            Console.WriteLine("\nInvalid input. Please enter 1 or 2.");
        }
    }
}
