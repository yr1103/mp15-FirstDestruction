namespace _260827_FirstDestruction;

public class Slime
{
    private const string postFix = "슬라임";
    private string _name;
    private int _health;
    private int _damage;
    
    public string Name => _name;
    public int Health => _health;
    public int Damage => _damage;

    public Slime(string name, int health, int damage)
    {
        _name = name + postFix;
        _health = health;
        _damage = damage;
    }

    public void Attack()
    {
        Console.WriteLine($"{Name}이 공격을 시작했다!");
        Console.WriteLine($"{Damage} 만큼 피해를 입혔다!");
    }

    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name}이 공격을 받았다!");
        _health -= damage;
        Console.WriteLine($"{Name}의 체력이 {damage}만큼 감소했다");
    }
}