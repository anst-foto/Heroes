namespace Heroes.Core;

public class BugWarrior : Bug, IWarrior
{
    private const int DAMAGE_RATE = 50;

    public int DamageRate { get; init; }

    public BugWarrior(string name) : base(name)
    {
        DamageRate = DAMAGE_RATE;
    }


    public void Attack(Hero hero) => hero.Health -= DamageRate;
}
