namespace TextBasedAdventure;

public class Game
{
    // Declare the scenarios
    private static Scenario? _startingScenario, _scenario1, _scenario2, _scenario1_1, _scenario1_2,
        _scenario2_1, _scenario2_2, _scenario1_1_1, _scenario1_1_2, _scenario1_2_1,
        _scenario1_2_2, _scenario2_1_1, _scenario2_1_2, _scenario2_2_1, _scenario2_2_2,
        _finalScenario1, _finalScenario2, _finalScenario3, _finalScenario4,
        _finalScenario5, _finalScenario6, _finalScenario7, _finalScenario8,
        _finalScenario9, _finalScenario10, _finalScenario11, _finalScenario12,
        _finalScenario13, _finalScenario14, _finalScenario15, _finalScenario16;
    
    /**************************************************************
    * RUN
    * Create and link scenarios then start the recursive gameplay
    ***************************************************************/
    public static void Run()
    {
        CreateScenarios();
        LinkScenarios();

        // Start the story
        _startingScenario?.Play();
    }

    /**************************************************************
    * CREATE SCENARIOS
    * Create all scenarios
    ***************************************************************/
    private static void CreateScenarios()
    {
        // Starting scenario and choices
        _startingScenario = new Scenario("You find yourself standing at a crossroads in a dense forest. The path diverges into two directions.", 
            "Take the left path", null, 
            "Take the right path", null);

        // Second scenario and choices
        _scenario1 = new Scenario("You decide to take the left path. As you walk deeper into the forest, you encounter a mysterious old man sitting by a campfire. He offers you a small, ancient-looking map.",
            "Accept the map and engage in conversation with the old man", null,
            "Politely decline the map and continue on your way", null);
        _scenario2 = new Scenario("Opting for the right path leads you to a clearing where you discover a hidden treasure chest partially buried in the ground.",
            "Open the treasure chest to see what's inside", null,
            "Ignore the treasure chest and explore the surrounding area", null);

        // Third _scenario and choices
        _scenario1_1 = new Scenario("The old man shares tales of the forest's secrets and warns you of a hidden danger ahead. He suggests an alternative route to bypass the danger.",
            "Follow the alternative route", null,
            "Ignore the old man's advice and proceed with the original path", null);
        _scenario1_2 = new Scenario("As you walk further, you encounter a group of friendly woodland creatures that guide you to a magical waterfall with healing properties.",
            "Drink from the waterfall and rest for a while", null,
            "Thank the creatures and continue your journey", null);
        _scenario2_1 = new Scenario("Inside the chest, you find a mystical artifact that grants you the ability to communicate with the forest spirits.",
            "Use the artifact to seek guidance from the forest spirits", null,
            "Put the artifact away and continue your journey without seeking guidance", null);
        _scenario2_2 = new Scenario("As you explore, you come across an ancient stone circle with glowing symbols. It emanates a mysterious energy.",
            "Touch the symbols and try to unlock their secrets", null,
            "Choose to observe the stone circle from a distance and proceed cautiously", null);

        // Fourth _scenario and choices
        _scenario1_1_1 = new Scenario("Following the alternative route, you discover an ancient temple hidden deep within the forest. Inside, a wise sage imparts ancient wisdom and offers you a choice.",
            "Embrace the wisdom and gain a new ability", null,
            "Politely thank the sage and continue your journey", null);
        _scenario1_1_2 = new Scenario("Ignoring the warning, you stumble upon a territory of territorial creatures. They challenge you to a friendly competition.",
            "Accept the challenge and showcase your skills", null,
            "Attempt to peacefully negotiate and avoid the competition", null);
        _scenario1_2_1 = new Scenario("After resting, you find a hidden path that leads to a mystical grove. The grove offers you a chance to communicate with nature.",
            "Connect with nature and gain insights", null,
            "Leave the grove and continue your journey", null);
        _scenario1_2_2 = new Scenario("The creatures give you a magical amulet as a token of gratitude. The amulet has an unknown power.",
            "Experiment with the amulet's power", null,
            "Keep the amulet but refrain from using its power", null);
        _scenario2_1_1 = new Scenario("The forest spirits guide you to a magical portal that can transport you to a different realm.",
            "Enter the portal and explore the new realm", null,
            "Choose not to enter the portal and continue your journey in the forest", null);
        _scenario2_1_2 = new Scenario("Without guidance, you come across a mystical tree with glowing fruits. Each fruit represents a different choice.",
            "Eat a glowing fruit and embrace the consequence", null,
            "Choose not to eat any fruit and proceed cautiously", null);
        _scenario2_2_1 = new Scenario("Touching the symbols activates a magical pathway to a hidden grove where mystical creatures reside.",
            "Interact with the creatures and learn from their ancient knowledge", null,
            "Observe the creatures from a distance and proceed with caution", null);
        _scenario2_2_2 = new Scenario("Observing from a distance, you notice a faint trail leading to a forgotten shrine.",
            "Investigate the shrine and uncover its secrets", null,
            "Decide to leave the shrine undisturbed and continue your journey", null);

        // Final scenarios
        _finalScenario1 = new Scenario("As you rule with newfound power, your decisions shape the world. Some view you as a benevolent leader, while others see you as a tyrant. Your legacy echoes through generations, leaving a mark on the land you now govern.\n\nYou found ending #1 out of 16!");
        _finalScenario2 = new Scenario("Guided by the wisdom of the sage, you embark on a quest to share knowledge and bring prosperity to the realms beyond the forest. Your journey becomes a lifelong pursuit of enlightenment, leaving a positive impact on those you encounter.\n\nYou found ending #2 out of 16!");
        _finalScenario3 = new Scenario("The creatures lead you through the forest, forming a bond of mutual understanding. You emerge from the woods as a protector of nature, working alongside the creatures to maintain the delicate balance between the mystical and the mundane.\n\nYou found ending #3 out of 16!");
        _finalScenario4 = new Scenario("Your diplomatic approach impresses the creatures, forging an alliance between your kind and theirs. The territory becomes a haven of coexistence, and you continue your journey as a symbol of diplomacy and understanding.\n\nYou found ending #4 out of 16!");
        _finalScenario5 = new Scenario("As you commune with nature in the mystical grove, you become a guardian of the natural order. Your bond with the environment grants you the ability to heal and protect, and you emerge from the forest as a steward of the land.\n\nYou found ending #5 out of 16!");
        _finalScenario6 = new Scenario("Continuing your journey after resting, you encounter challenges and triumphs. The creatures' parting gift aids you along the way, and you emerge from the forest with a sense of resilience and determination.\n\nYou found ending #6 out of 16!");
        _finalScenario7 = new Scenario("Your experiments unveil the amulet's power to heal and protect. With newfound abilities, you overcome obstacles and adversaries. The amulet becomes a symbol of resilience, and you emerge from the forest as a formidable force.\n\nYou found ending #7 out of 16!");
        _finalScenario8 = new Scenario("Choosing caution over experimentation, you navigate the forest carefully with the amulet by your side. The journey is challenging, but your careful approach ensures a safe and uneventful emergence from the mystical woods.\n\nYou found ending #8 out of 16!");
        _finalScenario9 = new Scenario("The new realm unveils wonders and challenges. Gaining insights, you return to your world with newfound wisdom. Your experiences in both realms shape you into a wise traveler, forever changed by the mysteries you've encountered.\n\nYou found ending #9 out of 16!");
        _finalScenario10 = new Scenario("Choosing to stay in the familiar forest, you utilize the guidance of the forest spirits to navigate successfully. Emerging with a sense of accomplishment, you become a protector of the mystical secrets that lie within the ancient woods.\n\nYou found ending #10 out of 16!");
        _finalScenario11 = new Scenario("The ability granted by the fruit enhances your understanding of the forest's inhabitants. Your newfound skill becomes a gift, helping you navigate the woods with ease and ensuring a safe emergence.\n\nYou found ending #11 out of 16!");
        _finalScenario12 = new Scenario("Your cautious approach pays off as you navigate the forest carefully. The journey is uneventful, but the lessons in subtlety and observation shape you into a thoughtful and discerning traveler.\n\nYou found ending #12 out of 16!");
        _finalScenario13 = new Scenario("The creatures share ancient knowledge, enlightening you about the forest's secrets. With newfound wisdom, you emerge from the woods as a seeker of knowledge, forever connected to the mystical realm.\n\nYou found ending #13 out of 16!");
        _finalScenario14 = new Scenario("Learning valuable lessons in caution and subtlety, you navigate the forest carefully. Your observations shape you into a discerning traveler, and you emerge from the woods unharmed and enriched.\n\nYou found ending #14 out of 16!");
        _finalScenario15 = new Scenario("Discovering ancient artifacts in the shrine, you gain insights that aid you in navigating the forest. Emerging unharmed and enriched, you carry the artifacts with you as a testament to the hidden wonders within the woods.\n\nYou found ending #15 out of 16!");
        _finalScenario16 = new Scenario("Respecting the shrine's sanctity, you continue your journey undisturbed. The forest reveals its beauty to you, and you emerge with a profound sense of peace. Your respectful approach leaves a positive mark on the mystical realm you traversed.\n\nYou found ending #16 out of 16!");
}

    /**************************************************************
    * LINK SCENARIOS
    * Link each scenario's options to the next scenario
    ***************************************************************/
    private static void LinkScenarios()
    {
        // Linking starting scenario choices
        _startingScenario.Option1 = _scenario1;
        _startingScenario.Option2 = _scenario2;

        // Linking second-level choices 
        _scenario1.Option1 = _scenario1_1;
        _scenario1.Option2 = _scenario1_2;
        _scenario2.Option1 = _scenario2_1;
        _scenario2.Option2 = _scenario2_2;

        // Linking third-level choices
        _scenario1_1.Option1 = _scenario1_1_1;
        _scenario1_1.Option2 = _scenario1_1_2;
        _scenario1_2.Option1 = _scenario1_2_1;
        _scenario1_2.Option2 = _scenario1_2_2;
        _scenario2_1.Option1 = _scenario2_1_1;
        _scenario2_1.Option2 = _scenario2_1_2;
        _scenario2_2.Option1 = _scenario2_2_1;
        _scenario2_2.Option2 = _scenario2_2_2;

        // Linking fourth-level choices to final scenarios
        _scenario1_1_1.Option1 = _finalScenario1;
        _scenario1_1_1.Option2 = _finalScenario2;
        _scenario1_1_2.Option1 = _finalScenario3;
        _scenario1_1_2.Option2 = _finalScenario4;
        _scenario1_2_1.Option1 = _finalScenario5;
        _scenario1_2_1.Option2 = _finalScenario6;
        _scenario1_2_2.Option1 = _finalScenario7;
        _scenario1_2_2.Option2 = _finalScenario8;
        _scenario2_1_1.Option1 = _finalScenario9;
        _scenario2_1_1.Option2 = _finalScenario10;
        _scenario2_1_2.Option1 = _finalScenario11;
        _scenario2_1_2.Option2 = _finalScenario12;
        _scenario2_2_1.Option1 = _finalScenario13;
        _scenario2_2_1.Option2 = _finalScenario14;
        _scenario2_2_2.Option1 = _finalScenario15;
        _scenario2_2_2.Option2 = _finalScenario16;
    }
}
