using DndTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public class SavingThrow : ISavingThrow
    {
        public IAttribute Attribute { get; set; }
        public bool IsProficient { get; set; }
        public int SaveValue { get; set; }

        public SavingThrow() { 
        }    
    }
}
