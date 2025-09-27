using UnityEngine;

public class MoveDown : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}