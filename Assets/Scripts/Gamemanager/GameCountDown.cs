using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameCountDown : MonoBehaviour
{
    private float timer;
    public float gameCountDown;
    public GameObject gameTimer;
    private TextMeshPro timerText;

    void Start()
    {
        timerText = gameTimer.GetComponent<TextMeshPro>();
        timer = gameCountDown + 0.5f;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.SetText(Math.Round(timer).ToString());


        if (timer < 0)
        {
            timer = gameCountDown + 0.5f;
            Debug.Log("Restart");
            // EndOrRestartGame.RestartThisScene();
            SceneManager.LoadScene(0); // TODO

        }
    }
}
