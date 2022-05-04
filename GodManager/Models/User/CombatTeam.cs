using GodManager.Models.Combat;
using GodManager.Models.Enums;

namespace GodManager.Models.User;
public class CombatTeam : BaseModel
{
    public IList<GodInCombat> Gods {get;set;}
    public Team CurrentTeam {get;set;}
}