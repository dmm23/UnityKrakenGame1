using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent()]
[RequireComponent(typeof(BoxCollider))]
public class TriggerVolume : MonoBehaviour
{
    public UnityEvent OnEnterTrigger;

    private Collider _collider;

    [Header("Gizmo Settings")]
    [SerializeField]
    private bool _dispalyGizmos = false;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        OnEnterTrigger.Invoke();
        Gizmos.DrawCube(transform.position)
    }

    private void OnDrawGizmos()
    {
        if (_displayGizmos == false)
            return;
    }
    
    private void OnDrawGizmosSelected()
    {
        if (_displayGizmos == false)
            return;
    }

}
