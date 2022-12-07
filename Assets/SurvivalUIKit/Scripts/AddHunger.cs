using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SphereCollider))]
public class AddHunger : MonoBehaviour
{
    [SerializeField] private float _HungerReplenish, _thirstReplenish;
    private void Awake()
    {
        GetComponent<SphereCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            return;
        }
        var survivalUI = other.gameObject.GetComponent<SurvivalUI>();

        if (survivalUI is null) {
            return;
        }

        survivalUI.ReplenishHungerThirst(_HungerReplenish, _thirstReplenish);
        Destroy(gameObject);
    }
}
