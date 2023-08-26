namespace Heroes.Core;

using Bugs;
using Dragonflies;

public enum HeroType { Default, Bug, Dragonfly }

public enum SpecType { Default, Medic, Warrior }

public class HeroBuilder
{
    private string name;
    private HeroType heroType;
    private SpecType specType;

    public HeroBuilder AddName(string name)
    {
        this.name = name;
        return this;
    }

    public HeroBuilder SetHeroType(HeroType type)
    {
        this.heroType = type;
        return this;
    }

    public HeroBuilder SetSpecType(SpecType type)
    {
        this.specType = type;
        return this;
    }

    public Hero? Builder() =>
        this.heroType switch
        {
            HeroType.Bug => this.specType switch
            {
                SpecType.Medic => new BugMedic(this.name),
                SpecType.Warrior => new BugWarrior(this.name),
                _ => null
            },
            HeroType.Dragonfly => this.specType switch
            {
                SpecType.Medic => new DragonflyMedic(this.name),
                SpecType.Warrior => new DragonflyWarrior(this.name),
                _ => null
            },
            _ => null
        };
}
