using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerVolume : MonoBehaviour
{
    public UnityEvent OnEnterTrigger;

    private Collider _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        OnEnterTrigger.Invoke();
    }
}
