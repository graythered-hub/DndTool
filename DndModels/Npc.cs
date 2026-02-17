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
        public int InitiativeBonus;
        public CreatureType? CreatureType;
        public Alignment? Alignment;
        public List<Sense>? Senses;
        public string MovementSpeeds;
        public Size Size;
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
        public List<NpcAction>? Actions;
        

        public Npc()
        {
            id = Guid.NewGuid ();
        }

    }

    public abstract class NpcAction
    {
        public string Name = "Action";
        public string? Description;
        public ActionType ActionType;
    }

    public class NpcAttack : NpcAction
    {
        public AttackType Type;
        public int AttackValue;
        public DamageType DamageType;
        public string DamageValue;
        public bool Concentration;
        public string Distance;

        public NpcAttack()
        {
        }
        public NpcAttack(string name, AttackType attackType, int attackValue, DamageType damageType, string damageValue, bool concentration, string description)
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

    public class NpcNonAttack : NpcAction
    {
        public NpcNonAttack() { } 
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

    public enum ActionType
    {
        Action,
        BonusAction,
        Reaction
    }

    public enum CreatureType
    {
        Aberration,
        Beast,
        Celestial,
        Construct,
        Dragon,
        Elemental,
        Fey,
        Fiend,
        Giant,
        Humanoid,
        Monstrosity,
        Ooze,
        Plant,
        Undead,
    }
    
    public class Sense
    {
        public SenseType Type;
        public string Distance = "";
    }

    public enum SenseType
    {
        Blindsight,
        Darkvision,
        Truesight,
        Tremorsense
    }

    public enum Size
    {
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan
    }

    public enum Alignment
    {
        LawfulGood,
        LawfulEvil,
        LawfulNeutral,
        NeutralGood,
        NeutralEvil,
        TrueNeutral,
        ChaoticGood,
        ChaoticEvil,
        ChatoicNeutral
    }
}
