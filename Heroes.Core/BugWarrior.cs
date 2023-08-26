namespace Heroes.Core;

public class BugWarrior : Bug, IWarrior
{
    private const int DAMAGE_RATE = 50;

    public int Damage { get; init; }

    public BugWarrior(string name) : base(name) => this.Damage = DAMAGE_RATE;


    public void Attack(Hero hero) => hero.Health -= this.Damage;
}
