using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading;

public class ManageScenes : MonoBehaviour
{
    public GameManager gameManager;
    Scene activeScene;
    public GameObject pauseCanvas;

    public GameObject pauseScore;
    public GameObject timeOutScore;
    public GameObject timeOutCanvas;
    private TextMeshProUGUI pauseScoreText;
    private TextMeshProUGUI timeOutScoreText;
    private bool isGameOver;



    void Start()
    {
        activeScene = SceneManager.GetActiveScene();
        pauseCanvas.SetActive(false);
        timeOutCanvas.SetActive(false);
        isGameOver = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (activeScene.buildIndex == 0)
            {
                EndGame();
            }
            else
            {
                PauseGame();
            }

        }
    }

    public void timeOutGame()
    {
        timeOutCanvas.SetActive(true);
        timeOutScoreText = timeOutScore.GetComponent<TextMeshProUGUI>();
        timeOutScoreText.SetText(gameManager.countDroppings.ToString());
        isGameOver = true;
        Time.timeScale = 0; // Pauses Time
    }
    public void PauseGame()
    {
        if (!isGameOver)
        {
            pauseCanvas.SetActive(true);
            pauseScoreText = pauseScore.GetComponent<TextMeshProUGUI>();
            pauseScoreText.SetText(gameManager.countDroppings.ToString());
            Time.timeScale = 0; // Pauses Time
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1; // Resumes Time
        isGameOver = false;
        timeOutCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER 
            Application.OpenURL(webplayerQuitURL);
#else
            Application.Quit();
#endif
        }
    }
}