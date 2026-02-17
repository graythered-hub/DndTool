namespace DndTool.Models
{
    public interface ISavingThrow
    {
        IAttribute Attribute { get; set; }
        bool IsProficient { get; set; }
        int SaveValue { get; set; }
    }
}
