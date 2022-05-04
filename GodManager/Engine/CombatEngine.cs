using GodManager.Core.Services;
using GodManager.Models.Combat;
using GodManager.Models.Enums;
using GodManager.Models.User;

namespace GodManager.Engine;
public class CombatEngine : ICombatEngine
{
    private Combat? currentCombat {get;set;}
    private List<GodInCombat> godsInCombat {get;set;} = new List<GodInCombat>();

    public Combat DoCombat(IList<CombatTeam> combatTeams)
    {
        currentCombat = new Combat(combatTeams);

        PrepareGodsForCombat();
        var combatIsDone = false;

        int turnCounter = 0;
        while (!combatIsDone)
        {
            var currentPosition = turnCounter % godsInCombat.Count();
            var currentGod = godsInCombat[currentPosition];

            var combatTurn = DetermineActionForTurn(currentGod);
            currentCombat.CombatHistory.Add(combatTurn);

            var combatTempResult = IsCombatDone();
            combatIsDone = combatTempResult != null;
            turnCounter++;
        }

        return currentCombat;
    }

    private CombatTurn DetermineActionForTurn(GodInCombat godInCombat)
    {
        var combatTurn = new CombatTurn(godInCombat);

        return combatTurn;
    }

    private void PrepareGodsForCombat()
    {
        foreach (var team in currentCombat!.CombatTeams)
        {
            godsInCombat.AddRange(team.Gods.OrderByDescending(t => t.BaseGod.Dexerity));
        }
        godsInCombat = godsInCombat.OrderByDescending(t => t.BaseGod.Dexerity).ToList();
    }

    //Returns the victory team or null if the battle is still going on
    private Team? IsCombatDone()
    {
        var defeatedTeamsCount = 0;
        Team? victoryTeam = null;
        foreach (var team in currentCombat!.CombatTeams)
        {
            if (team.Gods.All(t => t.CurrentHealth <= 0))
            {
                defeatedTeamsCount++;
            }
            else
            {
                victoryTeam = team.CurrentTeam;
            }
        }
        if (defeatedTeamsCount + 1 == currentCombat!.CombatTeams.Count())
        {
            return victoryTeam;
        }
        return null;
    }
}