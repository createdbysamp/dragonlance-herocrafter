// initializing heroes
Warrior hero1 = new("Tanis", "Half-Elf", 90, 10, "Longsword");
Cleric hero2 = new("Raistlin", "Wizard", 65, 15, "Lightning");
Warrior hero3 = new("Sturm", "Knight", 90, 12, "Broadsword");

Warrior hero5 = new("Tasslehoff", "Kender", 60, 16, "Short Swords");

Warrior villian1 = new("Unknown", "Draconian", 25, 20, "Claws");
Cleric villian2 = new("Evenic", "DarkCleric", 65, 15, "Dark Fire");

// Cleric hero2 = new Cleric("Raistlin", "Cleric", 70, 15, "Lightning");
Warrior hero4 = new("Caramon", "Warrior", 105, 8, "Broadsword");
Cleric hero6 = new("Goldmoon", "Cleric", 80, 10, "Fireball");

// hero6.PerformSpecialAbility(hero4);
// hero4.PerformSpecialAbility(hero6);
// hero6.PerformSpecialAbility();

// Hero hero8 = new Hero();
// Hero hero10 = new Hero("Frank", "Sinatra", 0, -1);

// hero1.DisplayHeroInfo();
// hero1.TakeDamage(20);
// hero1.PerformAttack(hero1);

// hero3.DisplayHeroInfo();
// hero3.TakeDamage(45);
// hero3.PerformAttack(villian1);

// hero6.DisplayHeroInfo();
// hero6.TakeDamage(35);
// hero6.PerformAttack(villian1);

// villian1.DisplayHeroInfo();
// villian1.TakeDamage(5);
// villian1.Heal(23);
// villian1.PerformAttack(hero1);

// hero3.LevelUp(true);

// BattleSystem.Battle(hero3, villian1);

// round 1
Console.WriteLine("--- ROUND 1 ---");
BattleSystem.Battle(hero1, hero2);
Hero finalist1 = hero1.IsAlive ? hero1 : hero2;

// round 2
Console.WriteLine("\n=== ROUND 2 ===");
BattleSystem.Battle(villian1, hero4);
Hero finalist2 = villian1.IsAlive ? villian1 : hero4;

// round 3
Console.WriteLine("\n--- ROUND 3 ---");
BattleSystem.Battle(hero5, hero3);
Hero finalist3 = hero5.IsAlive ? hero5 : hero3;

// round 4
Console.WriteLine("\n=== ROUND 4 ===");
BattleSystem.Battle(villian2, hero6);
Hero finalist4 = villian2.IsAlive ? villian2 : hero6;

// reset health for a fair fight
Console.WriteLine("\n=== reset all health ===");
finalist1.Health = 100;
finalist2.Health = 100;
finalist3.Health = 100;
finalist4.Health = 100;

// run semifinals matches
Console.WriteLine("\n=== semi final1 ===");
BattleSystem.Battle(finalist1, finalist2);
Hero semiFine1 = finalist1.IsAlive ? finalist1 : finalist2;

Console.WriteLine("\n=== semi final2 ===");
BattleSystem.Battle(finalist3, finalist4);
Hero semiFine2 = finalist3.IsAlive ? finalist3 : finalist4;

// reset health for a fair fight
Console.WriteLine("\n=== reset finalist's health ===");
semiFine1.Health = 100;
semiFine2.Health = 100;

// final championship battle
Console.WriteLine("\n=== FINAL CHAMPIONSHIP ===");
BattleSystem.Battle(semiFine1, semiFine2);

// declare champion!!!
Hero champion = semiFine1.IsAlive ? semiFine1 : semiFine2;

// tell the world!
Console.WriteLine($"\n🍻 CHAMPION: {champion.Name}! ✨");
