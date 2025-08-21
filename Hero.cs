public class Hero
{
    // private fields - only accessible inside the Hero class
    private int _health = 0;
    private int _attackPower = 0;

    private static Random _random = new();

    // public auto-implemented properties - accessible from anywhere
    public string Name { get; set; }
    public string HeroType { get; set; }

    // public full properties

    public int Health
    {
        get { return _health; }
        set
        {
            if (value >= 0 && value <= 200)
            {
                _health = value;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThe hero is out of health...");
                _health = 0;
                Console.ResetColor();
            }
            ;
        }
    }
    public int AttackPower
    {
        get { return _attackPower; }
        set
        {
            if (value > 0)
            {
                _attackPower = value;
            }
            else
            {
                Console.WriteLine("Error - attack power must be greater than 0.");
            }
        }
    }

    // Constructor
    public Hero()
    {
        Name = "Unknown Hero";
        HeroType = "Adventurer";
        Health = 100;
        AttackPower = 10;
    }

    public Hero(string name, string heroType, int health, int attackPower)
    {
        Name = name;
        HeroType = heroType;
        Health = health;
        AttackPower = attackPower;
    }

    // member methods
    public void DisplayHeroInfo()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Class: {HeroType}");
        Console.WriteLine($"Fatigue: {Health}");
        Console.WriteLine($"Flex Power: {AttackPower}");
        Console.ResetColor();
    }

    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
        if (!IsAlive)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} the {HeroType} was defeated.");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine(
                $"{Name} the {HeroType} took {damageAmount} damage. Health: {Health}"
            );
        }
    }

    // attacking method

    public void PerformAttack(Hero target)
    {
        double randomMultiplier = _random.NextDouble() + .2;
        int actualDamage = (int)(AttackPower * randomMultiplier);

        Console.WriteLine($"{Name} attacks {target.Name} for {actualDamage} damage!");
        target.TakeDamage(actualDamage);
    }

    // JAM-MASTER CHALLENGES

    public bool IsAlive => Health > 0;

    public void Heal(int healAmount)
    {
        Health += healAmount;
        Console.WriteLine($"{Name} the {HeroType} healed by {healAmount}.");
        Console.WriteLine($"Current Health is: {Health}.");
    }

    public void LevelUp(bool didLevelUp)
    {
        AttackPower += 50;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{Name} the {HeroType} just leveled up!");
        Console.WriteLine($"New upgraded attack power is ... {AttackPower}");
        Console.ResetColor();
    }
}
