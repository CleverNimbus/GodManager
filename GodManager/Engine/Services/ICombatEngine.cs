using GodManager.Models.Combat;
using GodManager.Models.User;

namespace GodManager.Engine.Services;
public interface ICombatEngine
{
    Combat DoCombat(IList<CombatTeam> combatTeams);
}