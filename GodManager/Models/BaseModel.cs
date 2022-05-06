namespace GodManager.Models;
public abstract class BaseModel
{
    public int ID {get;set;}
    public string? InternalCode {get;set;}
    public DateTime ModelTimeStamp {get;set;} = DateTime.Now;
}