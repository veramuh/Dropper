using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;
    public GameManager GameManager;
    private float minX = -2;
    private float maxX = 2;

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed;
        transform.parent.Translate(movement * Time.deltaTime);

        if (transform.parent.position.x < minX)
        {
            Vector3 pos = transform.parent.position;
            pos.x = minX;
            transform.parent.position = pos;
        }

        if (transform.parent.position.x > maxX)
        {
            Vector3 pos = transform.parent.position;
            pos.x = maxX;
            transform.parent.position = pos;
        }
    }
}
