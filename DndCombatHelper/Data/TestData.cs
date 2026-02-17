using DndModels;

namespace DndCombatHelper.Data
{
    public static class TestData
    {
        //public static List<GenericEnemy> GetTestList() {
        //    List<GenericEnemy> enemies = new List<GenericEnemy>();
        //    enemies.Add(new GenericEnemy() {Name = "Adam", Description = "Does work. Gets blamed anyways for 'bad healing'." });
        //    enemies.Add(new GenericEnemy() { Name = "Mantis", Description = "Probably wanted to be dps but was beat by the insta-locks." });
        //    enemies.Add(new GenericEnemy() { Name = "Mag", Description = "Reliable. C&D hates you." });
        //    enemies.Add(new GenericEnemy() { Name = "Emma", Description = "Probably the best tank." });

        //    return enemies;
        //}

        public static IQueryable<Npc> GetNpcs()
        {
            IQueryable<Npc> npcs = new[] {
            new Npc() { Name = "Boblin", MaxHP = 12, CurrentHP = 12, InitiativeBonus = 4, AC = 15, Description = "Boblin is the best.", StrSave = 0, ConSave = 1 },
            new Npc() { Name = "Gray", MaxHP = 31, CurrentHP = 31, InitiativeBonus = 3, AC = 18, Description = "Josh is ok.", StrSave = 0, ConSave = 1 }
            }.AsQueryable();
            return npcs;
        }
    }
}
