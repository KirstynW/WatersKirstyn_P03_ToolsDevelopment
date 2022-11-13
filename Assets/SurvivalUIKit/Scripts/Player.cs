using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] int _maxHealth = 10;
    [SerializeField] int _currentHealth = 10;
    [SerializeField] AudioClip _hitAudio;

    public float _points;

    [SerializeField] private HealthBar _healthBar;

    void Start()
    {
        _currentHealth = _maxHealth;

        _healthBar.UpdateHealthBar(_maxHealth, _currentHealth);
    }

    void Update()
    {
        if (_currentHealth <= 0)
        {
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            if (_currentHealth >= 0)
            {
                _currentHealth -= 1;
                Debug.Log(_currentHealth);
                _healthBar.UpdateHealthBar(_maxHealth, _currentHealth);
                Debug.Log(_currentHealth);


            }
            else
            {
                _healthBar.UpdateHealthBar(_maxHealth, _currentHealth);
                Debug.Log(_currentHealth);
            }
        }
    }
}
