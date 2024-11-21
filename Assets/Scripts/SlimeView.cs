using System;
using TMPro;
using UnityEditor.VisionOS;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slime))]
[RequireComponent(typeof(SpriteRenderer))]
public class SlimeView : MonoBehaviour
{
    [SerializeField] private Sprite _upSprite, _downSprite;
    [SerializeField] private TextMeshProUGUI _deathCounterText;
    [SerializeField] private TextMeshProUGUI _healthCounterText;
    [SerializeField] private Slider _healthSlider;
    
    private Slime _slime;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _slime = GetComponent<Slime>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        _slime.OnUp += Up;
        _slime.OnDown += Down;
        _slime.OnDeath += Death;
        _slime.OnHealthChange += HealthChange;
    }

    private void OnDisable()
    {
        _slime.OnUp -= Up;
        _slime.OnDown -= Down;
        _slime.OnDeath -= Death;
        _slime.OnHealthChange -= HealthChange;
    }

    private void Up()
    {
        _spriteRenderer.sprite = _upSprite;
    }

    private void Down()
    {
        _spriteRenderer.sprite = _downSprite;
    }

    private void Death()
    {
        _deathCounterText.text = _slime.DeathCounter.ToString();
    }

    private void HealthChange(int currentHealth)
    {
        _healthSlider.value = currentHealth;
        _healthCounterText.text = $"{currentHealth}/5";
    }
}
