namespace Heroes.Core;

public abstract class Hero
{
    public string Name { get; init; }

    private int health;
    public int Health
    {
        get => this.health;
        set
        {
            if (value < 0)
            {
                this.health = 0;
            }
        }
    }

    protected Hero(int health, string name)
    {
        this.health = health;
        this.Name = name;
    }
}
