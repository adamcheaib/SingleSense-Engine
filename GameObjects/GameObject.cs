namespace SingleSenseEngine.GameObjects;

public class GameObject(string name, string description) : IInteractableObject
{
    public readonly string Name = name;
    public readonly string Description = description;

    public void Examine()
    {
        Console.WriteLine(this.Description);
    }
}