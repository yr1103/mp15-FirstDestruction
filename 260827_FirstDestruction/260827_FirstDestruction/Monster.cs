namespace _260827_FirstDestruction;

public class Slime
{
    private string _name;
    private int _health;
    private int _damage;
    
    public string Name => _name;
    public int Health => _health;
    public int Damage => _damage;

    public Slime(string name, int health, int damage)
    {
        _name = name;
        _health = health;
        _damage = damage;
    }
}