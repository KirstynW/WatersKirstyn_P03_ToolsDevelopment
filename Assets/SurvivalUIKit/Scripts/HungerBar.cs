using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    [SerializeField] Image _hungerBarSprite;
    [SerializeField] public float _hunger = 10;
    [SerializeField] int _numOfSecs;

    public void UpdateHungerBar(float _maxHunger, float _currentHunger)
    {
        _hungerBarSprite.fillAmount -= _currentHunger / _maxHunger * Time.deltaTime;
        Debug.Log(_currentHunger);
    }
}
