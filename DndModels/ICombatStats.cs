using DndModels;

namespace DndTool.Models
{
    public interface ICombatStats
    {
        IDefenseStats DefenseStats { get; set; }
        IAttackStats AttackStats { get; set; }

    }
}
