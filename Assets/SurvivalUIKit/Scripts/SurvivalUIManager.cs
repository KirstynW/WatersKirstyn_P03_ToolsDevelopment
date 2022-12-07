using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SurvivalUIManager : MonoBehaviour
{
    [SerializeField] private SurvivalUI _survivalUI;
    [SerializeField] private Image _hungerBar, _thirstBar, _healthBar;

    private void FixedUpdate()
    {
        _hungerBar.fillAmount = _survivalUI.HungerPercent;
        _thirstBar.fillAmount = _survivalUI.ThirstPercent;
        _healthBar.fillAmount = _survivalUI.HealthPercent;
    }
}
