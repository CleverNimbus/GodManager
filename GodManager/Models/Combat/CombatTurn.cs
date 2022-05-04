using GodManager.Core.Extensions;
using GodManager.Models.Enums;

namespace GodManager.Models.Combat;
public class CombatTurn : BaseModel
{
    public GodInCombat GodInCombat {get;set;}
    public Team Team {get;set;}

    public CombatTurn(GodInCombat godInCombat)
    {
        GodInCombat = godInCombat.CloneWithJson();
        Team = GodInCombat.Team;
    }
}