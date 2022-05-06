namespace GodManager.Models.User;
public class User : BaseModel
{
    public string UserName {get;set;}

    public int MoneyAmount {get;set;}
    public int JewelsAmount {get;set;}

    public IList<Hero> UserHeroes {get;set;} = new List<Hero>();
    public IList<God> UserGods {get;set;} = new List<God>();
    public IList<CombatTeam> CombatTeams {get;set;} = new List<CombatTeam>();

    public User(string userName)
    {
        this.UserName = userName;
    }
}