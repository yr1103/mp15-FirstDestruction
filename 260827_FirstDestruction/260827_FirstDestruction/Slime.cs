namespace _260827_FirstDestruction;

public class Slime : Monster
{
    private const string postFix = "슬라임";

    public Slime(string name, string howl, int health, int damage) : base(name, howl, health, damage)
    {
        _name = name + postFix;
        _howl = howl + howl;
        _health = health;
        _damage = damage;
    }

    public void Attack()
    {
        Console.WriteLine($"{Name}이 공격을 시작했다!");
        Console.WriteLine($"{Damage} 만큼 피해를 입혔다!");
    }

    public override void TakeDamage()
    {
        Console.WriteLine($"{Name}이 공격을 받았다!");
        _health -= Damage;
        Console.WriteLine($"{Name}의 체력이 {Damage}만큼 감소했다");
    }
}