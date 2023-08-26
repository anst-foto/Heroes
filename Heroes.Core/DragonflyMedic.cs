namespace Heroes.Core;

public class DragonflyMedic : Dragonfly, IMedic
{
    private const int HEALTH_RATE = 75;

    public DragonflyMedic(string name) : base(name)
    {
    }

    public void Heal(Hero hero) => hero.Health += HEALTH_RATE;
}
