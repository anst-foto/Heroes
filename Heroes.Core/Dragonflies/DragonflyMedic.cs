namespace Heroes.Core.Dragonflies;

public class DragonflyMedic : Dragonfly, IMedic
{
    private const int HEALTH_RATE = 75;

    public int HealRate { get; init; }

    public DragonflyMedic(string name) : base(name) => this.HealRate = HEALTH_RATE;

    public void Heal(Hero hero) => hero.Health += HEALTH_RATE;
}
