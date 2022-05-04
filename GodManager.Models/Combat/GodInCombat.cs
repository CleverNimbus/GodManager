using GodManager.Core.Models;
using GodManager.Models.User;

namespace GodManager.Models.Combat;
public class GodInCombat : BaseModel
{
    public God BaseGod {get;set;}

    public GodInCombat(God baseGod)
    {
        BaseGod = baseGod.CloneWithJson();
    }
}