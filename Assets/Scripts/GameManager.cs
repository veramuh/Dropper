using UnityEngine;
using TMPro;
using UnityEngine.UI;
using NUnit.Framework.Constraints;
using System;

public class GameManager : MonoBehaviour
{
    public GameObject counter;
    public GameObject paddle;
    public GameObject gameover;

    private TextMeshPro counterText;
    private TextMeshPro gameoverText;
    private int countDroppings;
    private int maxDroppings = 3;
    void Start()
    {
        counterText = counter.GetComponent<TextMeshPro>();
        gameoverText = gameover.GetComponent<TextMeshPro>();
        gameoverText.SetText("");
    }

    void Update()
    {
    }

    public void onPaddleTrigger(Collider other)
    {
        Debug.Log("Hit from Game Manager" + other.name);
        countDroppings++;
        counterText.SetText(countDroppings + "");

        if (countDroppings >= maxDroppings)
        {
            gameoverText.SetText("Won");
        }
    }
}
