using DndTool.Models;

namespace DndModels
{
    internal interface IPlayableCharacter
    {
        IPCIdentityInfo characterIdInfo { get; set; }
        List<IAttribute> attributes { get; set; }
        ICombatStats combatStats { get; set; }
        List<ICharacterClass> characterClasses { get; set; }
    }
}
