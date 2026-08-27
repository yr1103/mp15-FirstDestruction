namespace _260827_FirstDestruction;

public class Monster
{
    public int Health { get; private set; }
    public string Name { get; protected set; }
    public int Damage { get; set; }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
        }
    }
}