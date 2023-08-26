namespace Heroes.Core;

public abstract class Bug : Hero
{
    private const int HEALTH = 200;

    protected Bug(string name) : base(HEALTH, name) { }
}
