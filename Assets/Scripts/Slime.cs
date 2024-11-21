using System;
using UnityEngine;

public class Slime : MonoBehaviour, IDamageable
{
    public int Health => _currentHealth;
    public int DeathCounter => _deathCounter;

    public event Action OnUp, OnDown;
    public event Action<int> OnHealthChange;
    public event Action OnDeath;

    private int _maxHealth = 5, _currentHealth;
    private int _deathCounter;

    private void Start()
    {
        Heal();
    }

    [ContextMenu("Death")]
    public void Death()
    {
        _deathCounter++;

        OnDeath?.Invoke();

        Debug.Log("Death");

        Heal();
    }

    public void Heal()
    {
        _currentHealth = _maxHealth;

        OnHealthChange?.Invoke(_currentHealth);
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0) Death();

        OnHealthChange?.Invoke(_currentHealth);
    }

    private void OnMouseDown()
    {
        OnDown?.Invoke();

    }

    private void OnMouseUp()
    {
        OnUp?.Invoke();

        TakeDamage(1);
    }
}



