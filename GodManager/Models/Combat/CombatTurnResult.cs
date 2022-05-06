namespace GodManager.Models.Combat;

public class CombatTurnResult : BaseModel
{
    public CombatTurn CombatTurn {get;set;}

    public CombatTurnResult(CombatTurn combatTurn)
    {
        this.CombatTurn = combatTurn;
    }
}