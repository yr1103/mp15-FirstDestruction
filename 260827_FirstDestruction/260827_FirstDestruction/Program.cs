using System;
using _260827_FirstDestruction;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Destruction!");
        Slime slime = new("RED-RED", 300, 150);
        slime.Attack();
        slime.TakeDamage(100);
        
    }
}