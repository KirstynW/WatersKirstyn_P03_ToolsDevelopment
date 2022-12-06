using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivalUI : MonoBehaviour
{
    [Header("Hunger")]
    [SerializeField] private float _maxHunger = 100f;
    [SerializeField] private float _hungerDepletionRate = 1f;
    private float _currentHunger;
    public float HungerPercent => _currentHunger / _maxHunger;

    [Header("Thirst")]
    [SerializeField] private float _maxThirst = 100f;
    [SerializeField] private float _thirstDepletionRate = 1;
    private float _currentThirst;
    public float ThirstPercent => _currentHunger / _maxThirst;

    [Header("Stamina")]
    [SerializeField] private float _maxStamina = 100f;
    [SerializeField] private float _staminaDepletionRate = 1f;
    [SerializeField] private float _staminaRechargeRate = 2f;
    [SerializeField] private float _staminaRechargeDelay = 1f;
    private float _currentStamina;
    private float _currentStaminaDelayCounter;
    private float StaminaPercent => _currentStamina / _maxStamina;

    [Header("Player References")]
    [SerializeField] private GameObject _playerInput;

    void Start()
    {
        _currentHunger = _maxHunger;
        _currentThirst = _maxThirst;
        _currentStamina = _maxStamina;
    }

    void Update()
    {
        _currentHunger -= _hungerDepletionRate * Time.deltaTime;
        _currentThirst -= _thirstDepletionRate * Time.deltaTime;

        Debug.Log(_currentHunger + "Hunger");
        Debug.Log(_currentThirst + "Thirst");
    }
}
