

using DndTool.Models;

namespace DndModels
{
    public class GenericEnemy : IEnemy
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float CR { get; set; }

        public HashSet<Attribute>? attributes;

        public ICombatStats? Stats { get; set; }
        public GenericEnemy()
        {
            Name = "Generic";
            Description = "This is a generic enemy";
            CR = 0.25f;
            attributes = new HashSet<Attribute>();
            SetBaseAttributes();
            Stats = new BaseCombatStats(attributes);
        }

        public GenericEnemy(string name, string description, float cr)
        {
            Name = name;
            Description = description;
            CR = cr;
            SetBaseAttributes();
        }
        public void SetBaseAttributes()
        {
            foreach (AttributeType attr in Enum.GetValues(typeof(AttributeType)))
            {
                Attribute att = new Attribute(attr, 10);
                attributes.Add(att);
            }

        }
    }
}
