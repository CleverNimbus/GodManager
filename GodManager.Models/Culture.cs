using GodManager.Core.Models;

namespace GodManager.Models;
public class Culture : BaseModel
{
    public string CultureName {get;set;}

    public Culture(string cultureName)
    {
        CultureName = cultureName;
    }
}