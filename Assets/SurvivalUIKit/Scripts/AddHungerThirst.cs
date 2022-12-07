using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class AddHungerThirst : MonoBehaviour
{
    [SerializeField] private SurvivalUI _survivalUI;
    [SerializeField] private float _hungerReplenish, _thirstReplenish;
    private void Awake()
    {
        GetComponent<SphereCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }

        if (_survivalUI == null)
        {
            return;
        }

        _survivalUI.ReplenishHungerThirst(_hungerReplenish, _thirstReplenish);
        Destroy(gameObject);
    }
}
