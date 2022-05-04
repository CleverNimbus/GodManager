namespace GodManager.Models.Base;
public class Element : BaseModel
{
    public string Name {get;set;}

    public Element(string name)
    {
        Name = name;
    }
}