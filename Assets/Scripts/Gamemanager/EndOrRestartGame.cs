using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class EndOrRestartGame : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartThisScene();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }


    }


    public static void RestartThisScene()
    {
        SceneManager.LoadScene(1);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void EndGame()
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