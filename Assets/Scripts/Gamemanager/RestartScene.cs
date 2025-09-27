using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartThisScene();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
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


    public static void RestartThisScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}