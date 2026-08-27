using System;
using _260827_FirstDestruction;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Destruction!");
        Slime slime = new("RED-RED", 300, 150);
        Slime redSlime = new("REAL_RED", 9999, 999);
        slime.Attack();
        slime.TakeDamage(100);
        slime.TakeDamage(100);
        Console.WriteLine($"{slime.Name} 현재 체력 : {slime.Health}");
    }
    
    public Player player = new Player("용사", 100, 25);
}