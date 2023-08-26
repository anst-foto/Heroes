namespace Heroes.Core;

public class BugMedic : Bug, IMedic
{
    private const int HEALTH_RATE = 50;

    public BugMedic(string name) : base(name)
    {
    }

    public void Heal(Hero hero) => hero.Health += HEALTH_RATE;
}
