using System;

public interface IDamageable
{
    public event Action<int> OnHealthChange;
    public event Action OnDeath;

    public int Health { get; }

    public void TakeDamage(int damage);
    public void Heal();
    public void Death();
}



