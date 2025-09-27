using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    private LevelBounds levelBounds;
    public GameObject food;
    GameObject foodInstance;
    private float timer;
    public float foodSpeed = 5f;
    public float spawnTime = 1f;
    Vector3 spawnPosition;
    private float xMin;
    private float xMax;
    void Start()
    {
        levelBounds = GetComponentInParent<LevelBounds>();
        xMin = levelBounds.xMin + 0.25f;
        xMax = levelBounds.xMax - 0.25f;
        spawn();

    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > spawnTime)
        {
            spawn();
            timer = 0f;
        }
    }

    void spawn()
    {
        foodInstance = Instantiate(food, newSpawnPosition(), Quaternion.identity);
        foodInstance.GetComponent<MoveDown>().speed = foodSpeed;
        foodInstance.GetComponent<CheckBounds>().yMax = levelBounds.yMax;

    }
    private Vector3 newSpawnPosition()
    {
        float x = Random.Range(xMin, xMax);
        spawnPosition = new Vector3(x, 7, 0);
        return spawnPosition;
    }
}
