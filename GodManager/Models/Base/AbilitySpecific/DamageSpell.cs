namespace GodManager.Models.Base.AbilitySpecific;
public class DamageSpell : RootAbility
{
    public Element Element {get;set;}

    public DamageSpell(Element element)
    {
        this.Element = element;
        GodCanHaveAbility = true;
    }
}