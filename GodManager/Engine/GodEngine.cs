using GodManager.Core.Extensions;
using GodManager.Engine.Services;
using GodManager.Models.Base;
using GodManager.Models.Enums;
using GodManager.Models.Repository;
using GodManager.Models.User;

namespace GodManager.Engine;
public class GodEngine : IGodEngine
{
    public void RecalculateLevel(God god)
    {
        var tmpExp = god.Experience;
        var loopCounter = 0;
        while (tmpExp > 0)
        {
            loopCounter++;

            if (loopCounter == GodBase.MaxGodLevel)
            {
                break;
            }

            tmpExp -= GodBase.LevelIncrements[loopCounter];
        }
        god.level = loopCounter;
    }

    public void InitGodAffinities(GodBase godBase)
    {
        //Affinities default Values
        //The main god element is assigned as resist
        GodRepository.Instance.Elements.ToList().ForEach(x =>
            godBase.ElementAffinities.Add(x.CloneWithJson(),
                                          godBase.Element == x?AffinityType.Resist:AffinityType.Normal));
    }
}