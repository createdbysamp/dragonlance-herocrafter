// base class newest thing
class Cleric(string name, string heroType, int health, int attackPower, string spellType)
    : Hero(name, heroType, health, attackPower)
{
    // private classes

    private Random _rand = new Random();

    // auto-implemented classes
    public string SpellType { get; } = spellType;

    // override methods
    public override void PerformSpecialAbility(Hero target)
    {
        // implementation here
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{Name} chargest up their {SpellType} for a massive blast!");
        Console.ForegroundColor = ConsoleColor.DarkRed;
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
        Console.WriteLine($"{Name} hits with their {SpellType} for {AttackPower} damage!");
        base.PerformAttack(target);
    }

    public override void DisplayHeroInfo()
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"=== MAGE INFO ===");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {HeroType}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Attack Power: {AttackPower}");
        Console.WriteLine($"Weapon Type: {SpellType}");
        Console.WriteLine($"==================");
        Console.ResetColor();
    }
}
