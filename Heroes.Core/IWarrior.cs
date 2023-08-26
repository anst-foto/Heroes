namespace Heroes.Core;

public interface IWarrior
{
    public int Damage { get; init; }
    public void Attack(Hero hero);
}
