namespace DiscordBattler.GameObjects;

public class Combatant(
    string name,
    string description,
    int health,
    int energy,
    int power,
    int defence,
    int criticalChance,
    // Add a List or a Dictionary of abilities here
    int x,
    int y) : GameObject(name, description)
{
    public int Health = health;
    public int Energy = energy;
    public int Level = 1;
    public int Experience = 0;
    public int Power = power;
    public int Defence = defence;
    public int X = x;
    public int Y = y;

    public double CriticalChance = criticalChance;
    // Add weapon and armor types.
}