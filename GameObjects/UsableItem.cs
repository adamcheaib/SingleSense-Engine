using System.Collections.Concurrent;

namespace DiscordBattler.GameObjects;

public class UsableItem(
    string name,
    string description
    ) : GameObject(name, description)
{
    public void Consume(Combatant combatant)
    {
        // Make an algorithm for how items are used.
    }

    public void UseOn(Combatant combatant)
    {
        // Make an algorithm for how the item is used on someone other than the combatant himself. Might require that there is only one method!
    }
}