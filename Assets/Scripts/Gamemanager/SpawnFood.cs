using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject food;
    public LevelBounds levelBounds;
    GameObject foodInstance;


    public float speed = 5f;
    float posY;

    void Start()
    {
        foodInstance = Instantiate(food, new Vector3(0, 7, 0), Quaternion.identity);

        foodInstance.transform.gameObject.SetActive(true);
        foodInstance.transform.position = new Vector3(0, 7, 0);

    }

    void Update()
    {
        if (foodInstance != null)
        {

            posY = foodInstance.transform.position.y;

            foodInstance.transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

            if (posY < levelBounds.yMax)
            {
                Destroy(foodInstance);
                Debug.Log("Out of Bounds, Gameobject deleted.");
            }
        }
    }
}
