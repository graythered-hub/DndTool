using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public class Npc
    {
        public Guid id;
        public string? Name;
        public int Initiative;
        public int InitiativeBonus;
        public string? Description;
        public int? MaxHP;
        public int? CurrentHP;
        public int? AC;
        public int? StrSave;
        public int? ConSave;
        public int? DexSave;
        public int? WisSave;
        public int? IntSave;
        public int? ChaSave;
        public bool? IsConcentrating;
        public List<NpcAttack>? attacks;

        public Npc()
        {
            id = Guid.NewGuid ();
        }

    }

    public class NpcAttack
    {
        public string Name;
        public AttackType Type;
        public int AttackValue;
        public DamageType DamageType;
        public int DamageValue;
        public bool Concentration;
        public string? Description;

        public NpcAttack(string name)
        {
            Name = name;
        }
        public NpcAttack(string name, AttackType attackType, int attackValue, DamageType damageType, int damageValue, bool concentration, string description)
        {
            this.Name = name;
            this.Type = attackType;
            this.AttackValue = attackValue;
            this.DamageType = damageType;
            this.DamageValue = damageValue;
            this.Concentration = concentration;
            this.Description = description;
        }
    }

    public enum AttackType {
        Save,
        Hit
    }

    public enum ConditionType {
        Blindness,
        Deafness,
        Disadvantage
    }
    
}
