namespace GodManager.Models.Base;
public class Culture : BaseModel
{
    public string CultureName {get;set;}

    public Culture(string cultureName)
    {
        CultureName = cultureName;
    }
}