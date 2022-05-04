namespace GodManager.Models.Extensions;
public static class ExperienceExtensions
{
    public static void RecualculateLevel(this God god)
    {
        var tmpExp = god.Experience;
        var counter = 0;
        while (tmpExp > 0)
        {
            if (tmpExp - GodBase.LevelIncrements[counter] < 0)
            {
                god.level = counter;
            }
            if (counter == GodBase.MaxLevel)
            {
                god.level = counter;
            }
            tmpExp = tmpExp - GodBase.LevelIncrements[counter];
            god.level = counter;
            counter = counter + 1;
        }
    }
}