using System.Text.Json;
using DiscordBattler.GameEngine;
using DiscordBattler.GameObjects;

namespace DiscordBattler;

public class DiscordBattler
{
    public static void Main()
    {
        Player playerOne = new Player(
            "Mikael",
            "An amazing person.",
            100,
            100,
            1,
            1,
            0,
            1, 1
        );

        Combatant monster = new Combatant(
            "Fierce Monster",
            "A scary monster that is extremely scary.",
            100,
            100,
            1,
            1,
            0,
            4, 1
        );

        CombatManager fightSystem = new CombatManager();
        fightSystem.SetFighters(playerOne, monster);

        // Dictionary<string, Func<(string, int), int>> test = new Dictionary<string, Func<(string, int), int>>();

        Commands cmds = new Commands(new Dictionary<string, Action>());
        cmds.ValidateCommand("aoskdosakd");
        Console.WriteLine("Hej");
        
        // while (true)
        // {
        //     string input = "" + Console.ReadLine();
        //
        //     if (input == "end") break;
        //
        //     if (input == "map")
        //     {
        //         Map.PrintMap(playerOne);
        //         continue;
        //     }
        //     
        //     playerOne.Move(input);
        // }

        // Ends the game.
        Console.Write("Press any key to continue...");
        Console.ReadLine();
    }
}