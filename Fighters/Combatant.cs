using SingleSenseEngine.GameEngine;

namespace SingleSenseEngine.GameObjects;

public class Combatant(
    string name,
    string description,
    int health,
    int energy,
    int power,
    int armor,
    double criticalChance,
    double dodge,
    // Add a List or a Dictionary of abilities here
    int x,
    int y) : GameObject(name, description)
{
    public int Health = health;
    public int Energy = energy;
    public int Power = power;
    public int Armor = armor;
    public double Dodge = dodge; // Maximum of 5 due to the dice being rolled is a D6.
    public int X = x;
    public int Y = y;
    public double CriticalChance = criticalChance;

    private readonly Random _dice = new();
    // Add weapon and armor types.

    public bool Attack(Combatant target, int diceRoll)
    {
        // Target hits
        if (diceRoll >= target.Dodge)
        {
            float damageMultiplier = (_dice.Next(10) + 1) / 10f;
            target.TakeDamage((int)MathF.Round(Power * damageMultiplier));
            return true;
        }
        
        return false;
    }

    // Returns false if target dies!
    // TODO: This function might need some refactoring for the sake of readability.
    public int TakeDamage(int damage)
    {
        int damageTaken = damage; // For output!
        int damageToMitigate = Armor; // Saved in order to be used to calculate the amount of remaining damage after hitting armor!
        Armor = Armor - damage < 0 ? Armor = 0 : Armor -= damage; // Resets Defence to 0 if it becomes less. Otherwise decreases the damage amount from the total armor.
        damage = (damage - damageToMitigate) <= 0 ? 0 : damage - damageToMitigate; // Checks for the remaining damage after hitting the armor. 
        Health -= damage; // Decreases the remaining damage from HP!
        
        // TODO: The output needs to be triggered in the Battle Manager and not here!
        Console.WriteLine($"Action report:\n{Name} took {damageTaken} damage!\n{Name}'s HP: {Health}\nArmor: {Armor}");

        Console.WriteLine(-damageTaken);
        return -damageTaken;
    }

    // TODO: Implement later on. Something (maybe the Combat Manager) should reset temporary stats such as Defend which increases defence temporarily.
    public bool Defend()
    {
        return false;
    }

    // Returns boolean temporarily in case I want to implement an attempt on using items or whether an item had a successful usage?
    public bool UseItem(UsableItem item)
    {
        item.UseOn(this);
        return true;
    }

    // Should request to end the battle via the Combat Manager. Should print to output: Combatant.Name + " escaped successfully."
    public bool Run(CombatManager cbm)
    {
        // First do an RNG and then --> cbm.EndBattle()
        return false;
    }
}