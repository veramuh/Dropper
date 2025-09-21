using UnityEngine;

public class DroppingMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.parent.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
    }
}
