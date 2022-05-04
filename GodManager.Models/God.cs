using GodManager.Core.Models;
using GodManager.Models.Enums;
using GodManager.Models.Tools;

namespace GodManager.Models;
public class God : BaseModel
{
    public GodBase GodBase {get;set;}

    #region Equipment
    public Equipment? Equipment_01 {get;set;}
    public Equipment? Equipment_02 {get;set;}
    public Equipment? Equipment_03 {get;set;}
    public Equipment? Equipment_04 {get;set;}
    public Equipment? Equipment_05 {get;set;}
    #endregion Equipment

    #region Specific Base stats
    public int Strenght {get;set;}
    public int Inteligence {get;set;}
    public int Vitality {get;set;}
    public int Dexerity {get;set;}
    public int Luck {get;set;}
    #endregion Specific Base stats

    #region Specific Abilities
    public Ability Ability_01 {get;set;}
    public Ability Ability_02 {get;set;}
    public Ability Ability_03 {get;set;}
    public Ability Ability_04 {get;set;}
    public Ability Ability_05 {get;set;}
    public Ability Ability_06 {get;set;}
    #endregion Specific Abilities

    public Dictionary<Element, AffinityType> ElementAffinities {get;set;}
    
    private int experience = 0;
    public int Experience 
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
            this.RecualculateLevel();
        }
    }

    internal int level = 0;
    public int Level
    {
        get
        {
            if (level == 0)
                this.RecualculateLevel();
            return level;
        }
    }

    public God(GodBase godBase)
    {
        GodBase = godBase;
        Strenght = godBase.Strenght;
        Inteligence = godBase.Inteligence;
        Vitality = godBase.Vitality;
        Dexerity = godBase.Dexerity;
        Luck = godBase.Luck;
        ElementAffinities = godBase.ElementAffinities;
    }
}