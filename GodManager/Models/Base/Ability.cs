using GodManager.Models.Base.AbilitySpecific;

namespace GodManager.Models.Base;
public class Ability : BaseModel
{
    public string Name {get;set;}
    public string Description {get;set;}
    public RootAbility Type {get;set;}

    public Ability(string name, string description, RootAbility type)
    {
        Name = name;
        Description = description;
        Type = type;
    }
}