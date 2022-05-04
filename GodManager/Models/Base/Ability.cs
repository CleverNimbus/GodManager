using GodManager.Models.Enums;

namespace GodManager.Models.Base;
public class Ability : BaseModel
{
    public string Name {get;set;}
    public string Description {get;set;}
    public Element Element {get;set;}
    public AbilityType Type {get;set;}
    public bool IsFirstRoundAbility {get;set;}
    public bool IsFirstTurnAbility {get;set;}

    public Ability(string name, string description, Element element)
    {
        Name = name;
        Description = description;
        Element = element;
    }
}