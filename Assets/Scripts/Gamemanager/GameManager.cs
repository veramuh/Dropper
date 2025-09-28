using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework.Constraints;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject counter;
    public GameObject canvasCounter;
    private TextMeshPro counterText;
    public int countDroppings;
    public float plateSpeed = 5f;

    void Start()
    {
        counterText = counter.GetComponent<TextMeshPro>();
    }

    public void onPaddleTrigger(Collider2D other)
    {
        countDroppings++;
        counterText.SetText(countDroppings + "");
    }
}
