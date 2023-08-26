namespace Heroes.Core;

public abstract class Dragonfly : Hero
{
    private const int HEALTH = 100;

    protected Dragonfly(string name) : base(HEALTH, name)
    {
    }
}
