namespace Heroes.Core.Dragonflies;

public class DragonflyWarrior : Dragonfly, IWarrior
{
    private const int DAMAGE_RATE = 75;
    public int Damage { get; init; }

    public DragonflyWarrior(string name) : base(name) => this.Damage = DAMAGE_RATE;

    public void Attack(Hero hero) => hero.Health -= this.Damage;
}
