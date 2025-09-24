using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}