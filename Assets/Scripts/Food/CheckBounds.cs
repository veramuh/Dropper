using UnityEngine;

public class CheckBounds : MonoBehaviour
{
    [HideInInspector]
    public float yMax;
    float posY;

    void Update()
    {
        {
            posY = transform.position.y;

            if (posY < yMax)
            {
                // Debug.Log("Out of Bounds, Gameobject deleted.");
                Destroy(gameObject);
            }
        }
    }
}
