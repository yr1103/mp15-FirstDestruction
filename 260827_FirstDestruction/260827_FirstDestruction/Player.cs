namespace _260827_FirstDestruction;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Player(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    

}