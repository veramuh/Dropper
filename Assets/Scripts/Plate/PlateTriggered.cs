using System;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlateTriggered : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Hit by " + other.transform.parent.gameObject);
        Destroy(other.transform.parent.gameObject);
        GameManager.onPaddleTrigger(other);
    }
}
