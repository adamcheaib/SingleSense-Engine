using DiscordBattler.GameObjects;
namespace DiscordBattler.GameEngine;

public class BattleSystem
{
    private Combatant[] Fighters = new Combatant[2];
    private int currentTurn;
    
    // Always assigns the player to the first slot in the array.
    public void SetFighters(Combatant player, Combatant mob)
    {
        Fighters[0] = player;
        Fighters[1] = mob;
    }

    // If the number from the dice roll is even, the player starts and vice versa.
    private void DetermineFirstMove()
    {
        Random dice = new Random();
        int diceRoll = dice.Next(100);
        if (diceRoll % 2 == 0) currentTurn = 0;
        else currentTurn = 1;
    }

    //  This represents the index.
    private void SwitchTurns()
    {
        currentTurn = currentTurn == 0 ? 1 : 0;
    }
    
    // Add a method that makes the first 
}