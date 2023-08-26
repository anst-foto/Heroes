using Heroes.Core;

const int SQUAD_SIZE = 3;

var squad = new Hero[SQUAD_SIZE];
for (var i = 0; i < squad.Length; i++)
{
    Console.Write("Введите имя: ");
    var name = Console.ReadLine();

    var repeat = true;
    var typeHero = HeroType.Default;
    do
    {
        Console.WriteLine("Выберите тип персонажа");
        Console.WriteLine("1. Жук");
        Console.WriteLine("2. Стрекоза");
        var type = Console.ReadLine();
        switch (type)
        {
            case "1":
                typeHero = HeroType.Bug;
                repeat = false;
                break;
            case "2":
                typeHero = HeroType.Dragonfly;
                repeat = false;
                break;
            default:
                repeat = true;
                break;
        }
    } while (repeat);

    var typeSpec = SpecType.Default;
    do
    {
        Console.WriteLine("Выберите специализацию персонажа");
        Console.WriteLine("1. Медик");
        Console.WriteLine("2. Воин");
        var type = Console.ReadLine();
        switch (type)
        {
            case "1":
                typeSpec = SpecType.Medic;
                repeat = false;
                break;
            case "2":
                typeSpec = SpecType.Warrior;
                repeat = false;
                break;
            default:
                repeat = true;
                break;
        }
    } while (repeat);

    var builder = new HeroBuilder();
    squad[i] = builder.AddName(name).SetHeroType(typeHero).SetSpecType(typeSpec).Builder();
    PrintHeroInfo(squad[i]);
}

var enemyBuilder = new HeroBuilder();
var enemy = enemyBuilder.AddName("ENEMY").SetHeroType(HeroType.Bug).SetSpecType(SpecType.Warrior).Builder();
PrintHeroInfo(enemy);

foreach (var hero in squad)
{
    switch (hero)
    {
        case IMedic medic:
            medic.Heal(enemy);
            break;
        case IWarrior warrior:
            warrior.Attack(enemy);
            break;
    }
    PrintHeroInfo(hero);
    PrintHeroInfo(enemy);
}

return;

void PrintHeroInfo(Hero hero)
{
    Console.WriteLine($"{hero.Name} : {hero.Health}");
}
