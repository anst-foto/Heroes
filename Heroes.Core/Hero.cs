namespace Heroes.Core;

public abstract class Hero
{
    private readonly int maxHealth;

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
            else if (value > this.maxHealth)
            {
                this.health = this.maxHealth;
            }
            else
            {
                this.health = value;
            }
        }
    }

    protected Hero(int health, string name)
    {
        this.health = health;
        this.Name = name;
        this.maxHealth = health;
    }
}
