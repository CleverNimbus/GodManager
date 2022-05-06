using GodManager.Models.Enums;

namespace GodManager.Models.Base.AbilitySpecific;
public abstract class RootAbility : BaseModel
{
    public AbilityType AbilityType {get;set;}

    public bool HeroCanHaveAbility {get;set;}
    public bool GodCanHaveAbility {get;set;}

    public bool IsFirstRoundAbility {get;set;}
    public bool IsFirstSelfTurnAbility {get;set;}
    public bool IsFirstEnemyTurnAbility {get;set;}
    public bool IsAllSelfTurnsAbility {get;set;}
    public bool IsAllEnemyTurnsAbility {get;set;}
}