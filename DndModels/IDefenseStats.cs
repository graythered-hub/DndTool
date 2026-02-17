using DndTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public interface IDefenseStats
    {
        int HitPoints { get; set; }
        int MaxHitPoints { get; set; }
        int ArmorClass { get; set; }
        List<SavingThrow> SavingThrows { get; set; }
    }
}
