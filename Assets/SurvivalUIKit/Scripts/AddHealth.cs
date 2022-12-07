using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class AddHealth : MonoBehaviour
{
    [SerializeField] private SurvivalUI _survivalUI;
    [SerializeField] private float _healthReplenish;
    private void Awake()
    {
        GetComponent<SphereCollider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Attempting to destroy");
        if (!other.CompareTag("Player"))
        {
            return;
        }
        
        if (_survivalUI == null)
        {
            return;
        }
        
        _survivalUI.ReplenishHealth(_healthReplenish);
        
        Destroy(gameObject);
    }
}
