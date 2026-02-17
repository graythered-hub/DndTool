namespace DndTool.Models
{
    public interface IAttribute
    {
        AttributeType Name { get; set; }
        int Value { get; set; }
        int Bonus { get; set; }
    }

    public enum AttributeType
    {
        Strength,
        Dexterity,
        Constitution,
        Wisdom,
        Intelligence,
        Charisma
    }
}
