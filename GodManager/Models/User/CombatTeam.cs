using GodManager.Models.Combat;
using GodManager.Models.Enums;

namespace GodManager.Models.User;
public class CombatTeam : BaseModel
{
    public Hero Hero {get;set;}
    public IList<GodInCombat> Gods {get;set;}
    public Team CurrentTeam {get;set;}

    public CombatTeam(Hero hero, IList<GodInCombat> gods, Team currentTeam)
    {
        this.Hero = hero;
        this.Gods = gods;
        this.CurrentTeam = currentTeam;
    }
}