namespace GodManager.Models;
public class GodModel : BaseModel
{
    public const int MaxGodLevel = 50;
    public const int BaseLevelJump = 1000;
    public const decimal HighLevelCurveFactor = 0.4m;
    public static readonly int[] LevelIncrements;

    static GodModel()
    {
        LevelIncrements = new int[MaxGodLevel + 1];
        InitLevelIncrements();
    }

    private static void InitLevelIncrements()
    {
        LevelIncrements[0] = 0; //Not neccesary, just for clarity
        for (int i = 1; i <= MaxGodLevel; i++)
        {
            LevelIncrements[i] = (int)(BaseLevelJump * (i + (i * HighLevelCurveFactor)));
        }
    }
}