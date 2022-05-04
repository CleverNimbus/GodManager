using GodManager.Core.Models;

namespace GodManager.Models;
public class Element : BaseModel
{
    public string Name {get;set;}

    public Element(string name)
    {
        Name = name;
    }
}