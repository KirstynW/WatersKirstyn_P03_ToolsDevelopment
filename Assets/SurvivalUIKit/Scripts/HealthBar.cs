using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Image _healthBarSprite;

    public void UpdateHealthBar(float _maxHealth, float _currentHealth)
    {
        _healthBarSprite.fillAmount = _currentHealth / _maxHealth;
    }
}
