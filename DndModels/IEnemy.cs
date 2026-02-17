using DndTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    internal interface IEnemy
    {
        string Name { get; set; }
        string Description { get; set; }
        float CR { get; set; }
        ICombatStats? Stats { get; set; }
    }
}
