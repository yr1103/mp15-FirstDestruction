namespace _260827_FirstDestruction;

public abstract class Monster
{
    protected string _name;
    protected string _howl;
    protected int _health;
    protected int _damage;
    public int Health => _health;
    public string Name => _name;
    public string Howl => _howl;
    public int Damage => _damage;

    public Monster(string name, string howl, int health, int damage)
    {
        _name = name;
        _howl = howl;
        _health = health;
        _damage = damage;
    }
    public virtual void Howling()
    {
        Console.WriteLine($"{Name}이 울부짖습니다 {Howl}");
    }
    public abstract void TakeDamage();
}