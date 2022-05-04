using GodManager.Models.Combat;
using GodManager.Models.User;

namespace GodManager.Core.Services;
public interface ICombatEngine
{
    Combat DoCombat(IList<CombatTeam> combatTeams);
}