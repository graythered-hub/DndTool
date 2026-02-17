using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    internal interface IPCIdentityInfo
    {
        string Name { get; set; }
        string Background { get; set; }
        string Species { get; set; }
    }
}
