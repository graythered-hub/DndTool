using DndTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndModels
{
    public class BaseAttackStats : IAttackStats
    {
        public List<Attribute> characterAttributes;
        public int Hit { get; set; }
        public int MagicHit { get; set; }
        public int SpellSaveDC { get; set; }
        public int MartialSaveDC { get; set; }
        public Dictionary<MovementType, int> Movement { get; set; }

        public BaseAttackStats()
        {
            this.Hit = 0;
            this.MagicHit = 0;
            this.SpellSaveDC = 0;
            this.MartialSaveDC = 0;
            this.Movement = new Dictionary<MovementType, int>();
            this.characterAttributes = new List<Attribute>();
        }

        public BaseAttackStats(int hit, int magicHit, int spellSaveDC, int martialSaveDC, Dictionary<MovementType, int> movement, List<Attribute> characterAttributes)
        {
            Hit = hit;
            MagicHit = magicHit;
            SpellSaveDC = spellSaveDC;
            MartialSaveDC = martialSaveDC;
            Movement = movement;
            this.characterAttributes = characterAttributes;
        }

        public void AddMovementType(MovementType type, int speed)
        {
            Movement.Add(type, speed);
        }

        public void RemoveMovement(MovementType type)
        {
            Movement.Remove(type);
        }

        public void SetMovement(Dictionary<MovementType, int> movement)
        {
            Movement = movement;
        }

        public void SetBaseAttributes()
        {           
            foreach (AttributeType attr in Enum.GetValues(typeof(AttributeType)))
            {
                Attribute att = new Attribute(attr, 10);
                characterAttributes.Add(att);
            }

        }
    }
}
