namespace DiscordBattler.GameObjects;

public class Equipment : GameObject
{
    private EEquipmentTypes EquipmentType;
    private int RequiredLevel;

    public Equipment(string name, string description, EEquipmentTypes equipmentType, int requiredLevel) : base(name, description)
    {
        this.EquipmentType = equipmentType;
        this.RequiredLevel = requiredLevel;
    }

    public bool CheckRequirement(Combatant combatant)
    {
        return combatant.Level >= this.RequiredLevel;
    }
}