using System;
using Unity.VisualScripting;
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
        // other.transform.parent.gameObject.SetActive(false);
        Debug.Log(other.transform.parent.gameObject);
        Destroy(other.transform.parent.gameObject);
        GameManager.onPaddleTrigger(other);
    }
}
