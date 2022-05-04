namespace GodManager.Core.Models;
public class GodModel : BaseModel
{
    public const int MaxLevel = 50;
    public const int BaseLevelJump = 1000;
    public const decimal HighLevelCurveFactor = 0.4m;
    public static readonly int[] LevelIncrements;

    static GodModel()
    {
        LevelIncrements = new int[MaxLevel + 1];
        InitLevelIncrements();        
    }

    private static void InitLevelIncrements()
    {
        for (int i = 1; i <= MaxLevel; i++)
        {
            LevelIncrements[i] = (int)(BaseLevelJump * (i + (i * HighLevelCurveFactor)));
        }
    }
}