using System;
using UnityEngine;

public class PaddleTrigger : MonoBehaviour
{
    public GameManager GameManager;

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        GameManager.onPaddleTrigger(other);
    }
}
