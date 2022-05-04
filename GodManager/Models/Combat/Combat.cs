using GodManager.Core.Extensions;
using GodManager.Models.User;

namespace GodManager.Models.Combat;
public class Combat : BaseModel
{
    public IList<CombatTeam> CombatTeams {get;set;}

    public DateTime FightDate {get; private set;} = DateTime.UtcNow;

    public IList<CombatTurn> CombatHistory {get;set;} = new List<CombatTurn>();

    public Combat(IList<CombatTeam> combatTeams)    
    {
        CombatTeams = combatTeams.CloneWithJson();
    }
}