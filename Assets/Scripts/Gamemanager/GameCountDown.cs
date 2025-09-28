using UnityEngine;
using TMPro;
using System;

public class GameCountDown : MonoBehaviour
{
    private float timer;
    public float gameDuration;
    public GameObject gameTimer;
    private TextMeshPro timerText;

    public ManageScenes manageScenes;

    void Start()
    {
        timerText = gameTimer.GetComponent<TextMeshPro>();
        timer = gameDuration + 0.5f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.SetText(Math.Round(timer).ToString());


        if (timer < 0)
        {
            timer = gameDuration + 0.5f;
            manageScenes.timeOutGame();
        }
    }

}
