using GodManager.Core.Models;

namespace GodManager.Models.Base;
public class Ability : BaseModel
{
    public string Name {get;set;}
    public string Description {get;set;}
    public Element Element {get;set;}

    public Ability(string name, string description, Element element)
    {
        Name = name;
        Description = description;
        Element = element;
    }
}