using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework.Constraints;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject gameover;
    public GameObject counter;
    private TextMeshPro counterText;
    private TextMeshPro gameoverText;
    private int countDroppings;
    public float plateSpeed = 5f;

    void Start()
    {
        counterText = counter.GetComponent<TextMeshPro>();
        gameoverText = gameover.GetComponent<TextMeshPro>();
        gameoverText.SetText("");
    }

    void Update()
    {
    }

    public void onPaddleTrigger(Collider2D other)
    {
        countDroppings++;
        counterText.SetText(countDroppings + "");
    }
}
