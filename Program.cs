int heroHealthPoints = 10;
int monsterHealthPoints = 10;

Random dice = new();
int damage = 0;

do
{
    damage = dice.Next(1, 11);
    monsterHealthPoints -= damage;
    Console.WriteLine($"Monster has damaged and lost {damage} and now has {monsterHealthPoints} health");

    if (monsterHealthPoints > 0)
    {
        damage = dice.Next(1, 11);
        heroHealthPoints -= damage;
        Console.WriteLine($"Hero has damaged and lost {damage} and now has {heroHealthPoints} health");
    } else {
        Console.WriteLine("Hero wins!");
        return;
    }

} while (heroHealthPoints > 0);

Console.WriteLine("Monster wins!");
