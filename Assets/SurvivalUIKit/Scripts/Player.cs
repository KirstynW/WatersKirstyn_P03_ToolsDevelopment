using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    [SerializeField] int _maxHealth = 10;
    [SerializeField] int _currentHealth = 10;
    [SerializeField] int _maxHunger = 10;
    [SerializeField] int _currentHunger = 10;
    [SerializeField] AudioClip _hitAudio;

    public float _points;

    [SerializeField] private SurvivalBars _survivalBars;

    void Start()
    {
        _currentHealth = _maxHealth;

        _survivalBars.UpdateHealthBar(_maxHealth, _currentHealth);

        _currentHunger = _maxHunger;
        _survivalBars.UpdateHungerBar(_maxHunger,_currentHunger);
    }

    void Update()
    {
        if (_currentHealth <= 0)
        {
        }

        if (_currentHunger>=0) {
            _survivalBars.UpdateHungerBar(_maxHunger,_currentHunger);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hurt")
        {
            if (_currentHealth >= 0)
            {
                _currentHealth -= 1;
                Debug.Log(_currentHealth);
                _survivalBars.UpdateHealthBar(_maxHealth, _currentHealth);
                Debug.Log(_currentHealth);


            }
            else
            {
                _survivalBars.UpdateHealthBar(_maxHealth, _currentHealth);
                Debug.Log(_currentHealth);
            }
        }
    }
}
