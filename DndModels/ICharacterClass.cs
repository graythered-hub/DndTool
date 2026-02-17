using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public interface ICharacterClass
    {
        string Name { get; set; }
        int Level { get; set; }
    }
}
