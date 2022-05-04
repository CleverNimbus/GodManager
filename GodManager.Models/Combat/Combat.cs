using GodManager.Core.Models;

namespace GodManager.Models.Combat;
public class Combat : BaseModel
{
    public GodInCombat? God_A_01 {get;set;}
    public GodInCombat? God_A_02 {get;set;}
    public GodInCombat? God_A_03 {get;set;}
    public GodInCombat? God_A_04 {get;set;}
    public GodInCombat? God_A_05 {get;set;}
    public GodInCombat? God_A_06 {get;set;}

    public GodInCombat? God_B_01 {get;set;}
    public GodInCombat? God_B_02 {get;set;}
    public GodInCombat? God_B_03 {get;set;}
    public GodInCombat? God_B_04 {get;set;}
    public GodInCombat? God_B_05 {get;set;}
    public GodInCombat? God_B_06 {get;set;}

    public DateTime FightDate {get;set;} = DateTime.UtcNow;

    
}