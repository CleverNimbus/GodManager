namespace GodManager.Models.Base.AbilitySpecific;
public class PositionChange : RootAbility
{
    public PositionChange()
    {
        HeroCanHaveAbility = true;
        GodCanHaveAbility = false;
        IsAllSelfTurnsAbility = true;
    }
}