namespace Heroes.Core;

public class DragonflyWarrior : Dragonfly, IWarrior
{
    private const int DAMAGE_RATE = 75;
    public int DamageRate { get; init; }

    public DragonflyWarrior(string name) : base(name) => DamageRate = DAMAGE_RATE;

    public void Attack(Hero hero) => hero.Health -= DamageRate;
}
