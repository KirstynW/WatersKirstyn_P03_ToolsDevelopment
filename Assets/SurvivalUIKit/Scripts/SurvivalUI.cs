using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalUI : MonoBehaviour
{
    [Header("Hunger")]
    [SerializeField] private float _maxHunger = 100f;
    [SerializeField] private float _hungerDepletionRate = 1;
    [SerializeField] private float _currentHunger;
    public float HungerPercent => _currentHunger / _maxHunger;

    [Header("Thirst")]
    [SerializeField] private float _maxThirst = 100f;
    [SerializeField] private float _thirstDepletionRate = 1;
    [SerializeField] private float _currentThirst;
    public float ThirstPercent => _currentThirst / _maxThirst;

    [Header("Health")]
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _healthDepletionRate = 1f;
    [SerializeField] private float _currentHealth;
    public float HealthPercent => _currentHealth / _maxHealth;

    void Start()
    {
        _currentHunger = _maxHunger;
        _currentThirst = _maxThirst;
        _currentHealth = _maxHealth;
    }

    void Update()
    {
        //as long as _currentHunger is above 0 it would drain until it hits 0
        if (_currentHunger>=0) {
            _currentHunger -= _hungerDepletionRate * Time.deltaTime;
        }
        //if the _currentThirst is above 0 it would drain until it hits 0
        if (_currentThirst>=0) {
            _currentThirst -= _thirstDepletionRate * Time.deltaTime;
        }
        //if the _currentHunger or _currentThirst is below or equal to 0 it will drain the health
        if (_currentHunger<= 0 || _currentThirst <=0)
        {
            _currentHealth -= _healthDepletionRate * Time.deltaTime;
            Debug.Log(_currentHealth + "Health");
        }
        //if the _currentHealth is less than or equal to 0, Death() will execute
        if (_currentHealth<=0) {
            _currentHealth = 0;
            Death();
        }

        
    }

    void Death() {
        //enter death code
        Debug.Log("Player is dead");
    }

    public void ReplenishHungerThirst(float hungerAmount, float thirstAmount) {
        _currentHunger += hungerAmount;
        _currentThirst += thirstAmount;

        if (_currentHunger > _maxHunger) {
            _currentHunger = _maxHunger;
        }
        if (_currentThirst>_maxThirst) {
            _currentThirst = _maxThirst;
        }
    }
    public void ReplenishHealth(float healthAmount) {
        _currentHealth += healthAmount;
        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}
