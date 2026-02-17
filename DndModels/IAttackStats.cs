using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public interface IAttackStats
    {
        int Hit { get; set; }
        int MagicHit { get; set; }
        int SpellSaveDC { get; set; }
        int MartialSaveDC { get; set; }
        Dictionary<MovementType, int> Movement { get; set; }
    }

    public enum MovementType
    {
        Walk,
        Fly,
        FlyAndHover,
        Burrow,
        Swim,
        Climb
    }
}
