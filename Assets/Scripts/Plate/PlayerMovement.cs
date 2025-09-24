using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;

    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed;
        transform.parent.Translate(movement * Time.deltaTime);
    }
}
