using DndModels;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace DndCombatHelper.Data
{
    public static class TestData
    {
        public static IQueryable<Npc> GetNpcs()
        {
            IQueryable<Npc> npcs = new[] {
            new Npc() {
                Name = "Boblin",
                MaxHP = 12,
                CurrentHP = 12,
                CreatureType = CreatureType.Humanoid,
                Alignment = Alignment.TrueNeutral,
                MovementSpeeds = "30ft, 10ft flying (hover)",
                Senses = new List<Sense> {
                    new Sense {Type = SenseType.Darkvision, Distance = "60"}
                },
                Size = Size.Small,
                InitiativeBonus = 4,
                AC = 15,
                Description = "Boblin is the best.",
                StrSave = 0,
                ConSave = 1,
                DexSave = 2,
                WisSave = 3,
                IntSave = -3,
                ChaSave = -3,
                IsConcentrating = false,
                Actions = new List<NpcAction>()
                {
                    new NpcAttack {
                        Name = "Bite",
                        Description = "Bites someone for piercing",
                        Type = AttackType.Hit,
                        DamageType = DamageType.Piercing,
                        AttackValue = 3,
                        DamageValue = "1d6 + 3",
                        Distance = "Melee, 5ft",
                        Concentration = false
                    },
                    new NpcNonAttack {
                        Name = "Multi-Attack",
                        ActionType = ActionType.Action,
                        Description = "Can use two bites in one round."
                    }
                }
            }
            }.AsQueryable();
            return npcs;
        }
    }
}
