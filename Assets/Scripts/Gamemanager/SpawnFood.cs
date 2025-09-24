using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject food;
    public LevelBounds levelBounds;
    GameObject foodInstance;

    private float timer;
    public float foodSpeed = 5f;

    public float spawnTime = 1f;
    Vector3 spawnPosition = new Vector3(0, 7, 0);
    float posY;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            foodInstance = Instantiate(food, spawnPosition, Quaternion.identity);
            foodInstance.GetComponent<MoveDown>().speed = foodSpeed;
            foodInstance.GetComponent<CheckBounds>().yMax = levelBounds.yMax;

            timer = 0f;
        }
    }
}
