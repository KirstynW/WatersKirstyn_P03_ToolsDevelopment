using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalBars : MonoBehaviour
{
    [SerializeField] Image _healthBarSprite;
    [SerializeField] public int _healthAmount = 10;
    [SerializeField] Image _hungerBarSprite;
    [SerializeField] public float _hunger = 10;
    [SerializeField] int _numOfSecs;

    public void UpdateHealthBar(float _maxHealth, float _currentHealth)
    {
        _healthBarSprite.fillAmount = _currentHealth / _maxHealth;
    }
    public void UpdateHungerBar(float _maxHunger, float _currentHunger)
    {
        _hungerBarSprite.fillAmount = _currentHunger -= _maxHunger * Time.deltaTime;
        Debug.Log(_currentHunger);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
