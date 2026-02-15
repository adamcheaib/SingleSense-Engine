namespace DiscordBattler.GameEngine;

/*
    Example of how to add and execute  a command in the main file:

        1. Commands gameCommands = new Commands(); // !!! Make only one instance. This is basically the user controls!!!
        2. void testFunc(string[]? args) { Console.WriteLine("hejhopp") };
        3. gameCommands.AddCommand("start", testFunc);
        4. gameCommands.ExecuteCommand("start");

        If a command already exists the program will exit. This is to avoid any logical runtime errors.
 */

public class CommandsManager
{
    private readonly Dictionary<string, Action<string[]?>> _validCommands = new();
    private readonly Dictionary<string, string> _commandDescriptions = new();

    // TODO: MAYBE --> arg 'action' cannot be null! Needs to be refactored later on once development is over.
    public void AddCommand(string command, Action<string[]?> action, string description)
    {
        if (_validCommands.ContainsKey(command))
        {
            Console.WriteLine($"Commands Manager (error): '{command}' already exists!");
            Environment.Exit(1);
            return;
        }

        _commandDescriptions[command] = description;
        _validCommands[command] = action;
        Console.WriteLine($"Commands Manager: Command '{command}' has been loaded!");
    }

    public void PrintCommandInstructions(string command)
    {
        Console.WriteLine("\n\n");
        Console.WriteLine(_commandDescriptions[command]);
        Console.WriteLine("\n\n");
    }

    public void PrintAvailableCommands()
    {
        Console.WriteLine("Here are the available commands to use: ");
        foreach (var key in _validCommands.Keys)
        {
            Console.WriteLine($"\n- {key}");
        }
        Console.WriteLine("\nTo view instructions for a specific command, write: help [COMMAND].\nExample: help move");
    }

    public void ExecuteCommand(string userCmd)
    {
        string[] commandSplit = userCmd.Split(" ");
        string command = commandSplit[0];
        string[]? args = commandSplit.Skip(1).ToArray();

        // If the length of args is 0, make it null!
        args = args.Length == 0 ? null : args;

        // If invalid command is passed.
        if (!ValidateCommand(command))
        {
            Console.WriteLine($"I do not know how to '{command}'!");
            return;
        }

        if (args == null) _validCommands[command](null);
        else _validCommands[command](args);
    }

    // Validates the command and executes them on different conditions.
    private bool ValidateCommand(string userCmd)
    {
        if (!_validCommands.ContainsKey(userCmd)) return false;

        return true;
    }

    public void DeleteCommand(string command)
    {
        if (ValidateCommand(command))
        {
            _validCommands.Remove(command);

            // TODO: Needs to be removed in production. Only for debugging!
            Console.WriteLine($"'Commands Manager: {command}' has been removed from the commands list!");
            return;
        }

        Console.WriteLine($"Commands Manager (error): '{command}' is not a valid command to delete!");
    }
}