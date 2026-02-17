using DndTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public class Attribute : IAttribute
    {
        public AttributeType Name { get; set; }
        public int Value { get; set; }
        public int Bonus { get; set; }

        public Attribute( AttributeType type, int value) {
            this.Name = type;
            this.Value = value;
            this.Bonus = Convert.ToInt32(Math.Ceiling((value - 10.0) / 2));
        }

    }
}
