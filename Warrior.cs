// base class newest thing

public class Warrior(string name, string heroType, int health, int attackPower, string weaponType)
    : Hero(name, heroType, health, attackPower)
{
    // private properties
    private Random _rand = new Random();

    // auto-implemented property
    public string WeaponType { get; } = weaponType;

    // override methods
    public override void PerformSpecialAbility(Hero target)
    {
        // implementation here
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            $"{Name} slices twice with their {WeaponType} for {AttackPower * 2} damage!"
        );
        Console.ForegroundColor = ConsoleColor.Black;
        base.PerformAttack(target);
        base.PerformAttack(target);
        Console.ResetColor();
    }

    public override void PerformAttack(Hero target)
    {
        int roll = _rand.Next(1, 10);
        if (roll == 1)
        {
            PerformSpecialAbility(target);
        }
        else
        {
            Console.WriteLine($"{Name} cuts with their {WeaponType} for {AttackPower} damage!");
            base.PerformAttack(target);
        }
    }

    public override void DisplayHeroInfo()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"=== WARRIOR INFO ===");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {HeroType}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Attack Power: {AttackPower}");
        Console.WriteLine($"Weapon Type: {WeaponType}");
        Console.WriteLine($"==================");
        Console.ResetColor();
    }
}
