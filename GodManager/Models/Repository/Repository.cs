using GodManager.Models.Base;
using GodManager.Core.Extensions;

//https://en.wikipedia.org/wiki/Lists_of_deities_by_cultural_sphere

namespace GodManager.Models.Repository;
public partial class GodRepository
{
    public static GodRepository Instance {get;set;} = new GodRepository();

    public IList<Culture> Cultures {get;set;} = new List<Culture>();
    public IList<Element> Elements {get;set;} = new List<Element>();
    public IList<GodBase> Gods {get;set;} = new List<GodBase>();
    public IList<Equipment> Equipment {get;set;} = new List<Equipment>();

    public GodRepository()
    {
        InitializeData();
    }

    private void InitializeData()
    {
        #region Cultures
        var cultureAztec = new Culture("Aztec");
        Cultures.AddWithAutoID(cultureAztec);

        var cultureEgyptian = new Culture("Egyptian");
        Cultures.AddWithAutoID(cultureEgyptian);

        var cultureGreek = new Culture("Greek");
        Cultures.AddWithAutoID(cultureGreek);

        var cultureJapanese = new Culture("Japanese");
        Cultures.AddWithAutoID(cultureJapanese);
        #endregion Cultures

        #region Elements
        var elementWater = new Element("Water");
        Elements.AddWithAutoID(elementWater);

        var elementFire = new Element("Fire");
        Elements.AddWithAutoID(elementFire);

        var elementDeath = new Element("Death");
        Elements.AddWithAutoID(elementDeath);

        var elementLife = new Element("Life");
        Elements.AddWithAutoID(elementLife);

        var elementSky = new Element("Sky");
        Elements.AddWithAutoID(elementSky);

        var elementEarth = new Element("Earth");
        Elements.AddWithAutoID(elementEarth);
        #endregion Elements

        #region Gods
        #region Aztec
        var godTlaloc = new GodBase(
            "Tlāloc",
            cultureAztec,
            elementWater,
            "God of lightning, rain and earthquakes");
        Gods.AddWithAutoID(godTlaloc);

        var godXiuhtecuhtli = new GodBase(
            "Xiuhtecuhtli",
            cultureAztec,
            elementFire,
            "Father of the gods. God of fire");
        Gods.AddWithAutoID(godXiuhtecuhtli);

        var godXolotl = new GodBase(
            "Xolotl",
            cultureAztec,
            elementDeath,
            "God of twilight and twins, lord of monsters, misfortune, sickness, and deformities"
        );
        Gods.AddWithAutoID(godXolotl);
        #endregion Aztec

        #region Egyptian
        var godAnubis = new GodBase(
            "Anubis",
            cultureEgyptian,
            elementDeath,
            "Guardian of the dead, mummification, and the afterlife"
        );
        Gods.AddWithAutoID(godAnubis);
        #endregion Egyptian

        #region Greek
        var godThanatos = new GodBase(
            "Thanatos",
            cultureGreek,
            elementDeath,
            "King of the underworld"
        );
        godThanatos.ElementAffinities[elementLife] = Enums.AffinityType.Weak;
        Gods.AddWithAutoID(godThanatos);
        #endregion Greek

        #region Japanese
        var godShinigami = new GodBase(
            "Shinigami",
            cultureJapanese,
            elementDeath,
            "Good of Death"
        );
        godShinigami.ElementAffinities[elementSky] = Enums.AffinityType.Weak;
        Gods.AddWithAutoID(godShinigami);
        #endregion Japanese

        #endregion Gods
    }
}