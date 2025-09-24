using UnityEngine;

public class Timer : MonoBehaviour
{
    // A timer example to reuse
    private float timer;
    public float lap;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > lap)
        {
            Debug.Log("it's time");
            timer = 0f;
        }
    }
}
