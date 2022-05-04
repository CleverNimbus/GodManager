using GodManager.Core.Models;

namespace GodManager.Models.Base;
public class Equipment : BaseModel
{
    public string Name {get;set;}
    public string Description {get;set;}

    public Equipment(string name, string description)
    {
        Name = name;
        Description = description;
    }
}