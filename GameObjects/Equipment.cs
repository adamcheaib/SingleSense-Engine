namespace SingleSenseEngine.GameObjects;

public class Equipment : GameObject
{
    private EEquipmentTypes EquipmentType;

    public Equipment(string name, string description, EEquipmentTypes equipmentType, int requiredLevel) : base(name, description)
    {
        this.EquipmentType = equipmentType;
    }
}