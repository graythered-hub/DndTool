using DndTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public class BaseDefenseStats : IDefenseStats
    {
        public int HitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public int ArmorClass { get; set; }
        public List<SavingThrow> SavingThrows { get; set; }

        public BaseDefenseStats() {
            this.HitPoints = 0;
            this.MaxHitPoints = 0;
            this.ArmorClass = 0;
            this.SavingThrows = new List<SavingThrow>();
        }
    }
}
