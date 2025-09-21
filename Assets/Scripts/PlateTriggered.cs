using System;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class PlateTriggered : MonoBehaviour
{
    public GameManager GameManager;

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.parent.gameObject.SetActive(false);
        GameManager.onPaddleTrigger(other);
    }
}
