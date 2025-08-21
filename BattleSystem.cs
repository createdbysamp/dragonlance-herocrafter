public static class BattleSystem
{
    public static void Battle(Hero hero1, Hero hero2)
    {
        // welcome to the game!
        Console.WriteLine($"🔥 {hero1} vs {hero2} ✨");

        // game logic to check for aliveness and attack
        while (hero1.IsAlive && hero2.IsAlive)
        {
            Console.WriteLine("\n--- NEW TURN ---");

            if (hero1.IsAlive)
            {
                hero1.PerformAttack(hero2);
            }
            if (hero2.IsAlive)
            {
                hero2.PerformAttack(hero1);
            }
            // ui revision
            Console.WriteLine("Press any key to continue ...");
            Console.ReadLine();
        }
        // declare winner / end
        Console.WriteLine("END OF MATCH");

        // decide winner
        if (hero1.IsAlive)
        {
            Console.WriteLine($"{hero1.Name} WINS!! 🔥");
        }
        else if (hero2.IsAlive)
        {
            Console.WriteLine($"{hero2.Name} WINS!! ❄️");
        }
        else
        {
            Console.WriteLine("TIE TIE TIE");
        }
    }
}
