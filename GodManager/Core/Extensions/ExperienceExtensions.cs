using GodManager.Models.Base;
using GodManager.Models.User;

namespace GodManager.Core.Extensions;
public static class ExperienceExtensions
{
    public static void RecalculateLevel(this God god)
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
}