using GodManager.Models.Base;

namespace GodManager.Models.User;
public class Hero : BaseModel
{
    public string Name {get;set;}
    public Culture Culture {get;set;}
    public Element Element {get;set;}

    public Hero(string name, Culture culture, Element element)
    {
        this.Name = name;
        this.Culture = culture;
        this.Element = element;
    }
}