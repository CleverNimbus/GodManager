using GodManager.Models.Enums;

namespace GodManager.Models.Base.AbilitySpecific;
public abstract class RootAbility : BaseModel
{
    public AbilityType AbilityType {get;set;}

    public bool HeroCanHaveAbility {get;set;} = false;
    public bool GodCanHaveAbility {get;set;} = false;

    public bool IsFirstRoundAbility {get;set;} = false;
    public bool IsFirstSelfTurnAbility {get;set;} = false;
    public bool IsFirstEnemyTurnAbility {get;set;} = false;
    public bool IsAllSelfTurnsAbility {get;set;} = false;
    public bool IsAllEnemyTurnsAbility {get;set;} = false;
}