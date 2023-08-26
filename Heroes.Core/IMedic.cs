namespace Heroes.Core;

public interface IMedic
{
    public int HealRate { get; init; }
    public void Heal(Hero hero);
}
