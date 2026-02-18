using SingleSenseEngine.Fighters;
using SingleSenseEngine.GameEngine;
using SingleSenseEngine.GameObjects;

namespace SingleSenseEngine;

public class SingleSenseEngine
{
    public static void Main()
    {
        CommandsManager gameCommandsManager = new CommandsManager();

        Player playerOne = new Player(
            "Elias",
            "An amazing person.",
            100,
            100,
            4,
            0,
            0,
            0,
            1, 1
        );

        Combatant monster = new Combatant(
            "Fierce Monster",
            "A scary monster that is extremely scary.",
            100,
            100,
            10,
            5,
            0,
            0,
            4, 1
        );
        
        CombatManager fightSystem = new CombatManager(6);
        // fightSystem.SetFighters(playerOne, monster);
        
        gameCommandsManager.AddCommand("move", args =>
            {
                try
                {
                    string direction = args[0];
                    playerOne.Move(direction);
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("'move' needs a direction! Use either 'north/n' etc.");
                }
            },
            "The 'move' command allows you to move. You can move by providing a direction or the first letter of a direction. Valid directions are:\n- north\n- south\n- east\n- west\n\nExample: move north"
        );
        
        gameCommandsManager.AddCommand("help", args =>
        {
            if (args == null)
            {
                gameCommandsManager.PrintAvailableCommands();
            }
            else if (args.Length == 1)
            {
                gameCommandsManager.PrintCommandInstructions(args[0]);
            }
            else
            {
                Console.WriteLine("'help' accepts only one argument!");
            }
        }, "");
        
        gameCommandsManager.AddCommand("map", args =>
        {
            MapManager.PrintMap(playerOne);
        }, "Prints the map");
        
        Console.WriteLine("\n\n\n\n");
        
        //
        playerOne.Attack(monster, 5);
        
        while (true)
        {
            string input = "" + Console.ReadLine().Trim().ToLower();
            if (input == "end") break;
        
            gameCommandsManager.ExecuteCommand(input);
        }
        
        // Ends the game.
        Console.Write("Press any key to continue...");
        Console.ReadLine();
    }
}