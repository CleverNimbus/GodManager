using GodManager.Core.Extensions;
using GodManager.Models.Enums;
using GodManager.Models.User;

namespace GodManager.Models.Combat;
public class GodInCombat : BaseModel
{
    public God BaseGod {get;set;}
    public Team Team {get;set;}
    public int CurrentHealth {get;set;}

    public GodInCombat(God baseGod)
    {
        BaseGod = baseGod.CloneWithJson();
    }

    private void CalculateHealth()
    {
        CurrentHealth = BaseGod.Vitality * 1000;
    }
}