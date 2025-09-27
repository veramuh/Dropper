using UnityEngine;
using TMPro;
using System;
public class GameCountDown : MonoBehaviour
{
    private float timer;
    public float lap;
    public GameObject gameTimer;
    private TextMeshPro timerText;

    void Start()
    {
        timerText = gameTimer.GetComponent<TextMeshPro>();
        timer = lap + 0.5f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.SetText(Math.Round(timer).ToString());


        if (timer < 0)
        {
            timer = lap + 0.5f;
            Debug.Log("Restart");
            RestartScene.RestartThisScene();
        }
    }
}
