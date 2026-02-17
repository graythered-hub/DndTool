using DndTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    internal class BaseCombatStats : ICombatStats
    {
        HashSet<Attribute>? attributes;
        public IDefenseStats DefenseStats { get; set; }
        public IAttackStats AttackStats { get; set; }

        public BaseCombatStats(HashSet<Attribute> attributes)
        {
            DefenseStats = new BaseDefenseStats();
            AttackStats = new BaseAttackStats();
            this.attributes = attributes;
        }
    }
}
