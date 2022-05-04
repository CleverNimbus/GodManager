using GodManager.Core.Models;
using GodManager.Models.Enums;
using GodManager.Models.Repository;

namespace GodManager.Models.Base;
public class GodBase : GodModel
{
    public string Name {get;set;}
    public string Description {get;set;}
    public Culture Culture {get;set;}
    public Element Element {get;set;}

    #region Base Stats
    public int Strenght {get;set;}
    public int Inteligence {get;set;}
    public int Vitality {get;set;}
    public int Dexerity {get;set;}
    public int Luck {get;set;}
    #endregion Base Stats

    #region Base Abilities
    public Ability? Ability_01 {get;set;}
    public Ability? Ability_02 {get;set;}
    public Ability? Ability_03 {get;set;}
    public Ability? Ability_04 {get;set;}
    #endregion Base Abilities

    public Dictionary<Element, AffinityType> ElementAffinities {get;set;} = new Dictionary<Element, AffinityType>();

    public GodBase(string name, Culture culture, Element element, string description = "")
    {
        Name = name;
        Description = description;
        Culture = culture;
        Element = element;

        //Affinities default Values
        //The main god element is assigned as resist
        GodRepository.Instance.Elements.ToList().ForEach(x =>
            ElementAffinities.Add(x.CloneWithJson(),
                                  Element == x?AffinityType.Resist:AffinityType.Normal));
    }
}