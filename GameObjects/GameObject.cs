namespace DiscordBattler.GameObjects;

public class GameObject(string name, string description)
{
    public readonly string Name = name;
    public readonly string Description = description;

    public void Examine()
    {
        Console.WriteLine(this.Description);
    }
}