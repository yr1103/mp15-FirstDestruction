namespace _260827_FirstDestruction;

public class Player
{
    public string Name { get; }
    public int Health { get; }
    public int Damage { get; }

    public Player(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
}