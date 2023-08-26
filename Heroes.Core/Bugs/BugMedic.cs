namespace Heroes.Core.Bugs;

public class BugMedic : Bug, IMedic
{
    private const int HEALTH_RATE = 50;
    public int HealRate { get; init; }

    public BugMedic(string name) : base(name) => this.HealRate = HEALTH_RATE;
    public void Heal(Hero hero) => hero.Health += this.HealRate;
}
