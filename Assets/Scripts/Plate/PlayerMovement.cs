using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public float speed;
    private Vector2 movement;
    public GameManager GameManager;
    private float xMin;
    private float xMax;

    void Start()
    {
        speed = GameManager.GetComponent<GameManager>().plateSpeed;
        xMin = GameManager.GetComponent<LevelBounds>().xMin;
        xMax = GameManager.GetComponent<LevelBounds>().xMax;
    }
    void Update()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed;
        transform.parent.Translate(movement * Time.deltaTime);

        if (transform.parent.position.x < xMin)
        {
            Vector3 pos = transform.parent.position;
            pos.x = xMin;
            transform.parent.position = pos;
        }

        if (transform.parent.position.x > xMax)
        {
            Vector3 pos = transform.parent.position;
            pos.x = xMax;
            transform.parent.position = pos;
        }
    }
}
