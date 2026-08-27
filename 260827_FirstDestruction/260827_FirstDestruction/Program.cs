using System;
using _260827_FirstDestruction;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Destruction!");
        Slime slime = new("RED-RED", "슬라슬라", 300, 150);
        slime.Attack();
        slime.TakeDamage();
        slime.TakeDamage();
        slime.TakeDamage();
    }

    private Player player = new Player("용사", 100, 25);
}