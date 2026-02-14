using System.Text.Json;
using DiscordBattler.GameEngine;
using DiscordBattler.GameObjects;

namespace DiscordBattler;

public class DiscordBattler
{
    public static void Main()
    {
        CommandsManager gameCommandsManager = new CommandsManager();
        
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

        void testFunc(object? args)
        {
            Console.WriteLine("hej");
        }
        
        gameCommandsManager.AddCommand("hej", testFunc);
        gameCommandsManager.DeleteCommand("hej");
        gameCommandsManager.DeleteCommand("rastaman");
        playerOne.Move("e");
        
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