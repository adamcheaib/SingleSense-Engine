using DiscordBattler.GameObjects;

namespace DiscordBattler.GameEngine;

public class CombatManager
{
    // The Fighters collection needs to be dynamic in order to be able handle fights greather than 1v1. For when the game has GUI.
    private Combatant[] Fighters = new Combatant[2];
    private int currentTurn;

    // Always assigns the player to the first slot in the array.
    public void SetFighters(Combatant player, Combatant mob)
    {
        // This needs to have a mathematical formula attached to it so it is not very arbitrary.
        Fighters[0] = player;
        Fighters[1] = mob;
        DetermineFirstMove();
    }

    // If the number from the dice roll is even, the player starts and vice versa.
    private void DetermineFirstMove()
    {
        Random dice = new Random();
        int diceRoll = dice.Next(100);
        currentTurn = diceRoll % 2 == 0 ? 0 : 1;
        
        // TODO: Remove in prod.
        Console.WriteLine($"The first fighter is {Fighters[currentTurn].Name}");
        
    }

    //  This represents the index.
    private void FlipTurns()
    {
        currentTurn = currentTurn == 0 ? 1 : 0;
        
        // TODO: Remove in prod.
        Console.WriteLine($"The turns have been swapped and it is now {Fighters[currentTurn].Name}'s turn");
    }

    // Add a method that handles a turn
    private void HandleTurn()
    {
        Combatant currentFighter = Fighters[currentTurn];

        // Checks for player turn
        if (currentFighter is Player)
        {
            // Print player actions.    
        }

        else if (currentFighter is not Player)
        {
            // Mob turn
        }
    }
}