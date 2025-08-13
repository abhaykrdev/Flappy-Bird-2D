using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud; // The cloud prefab to spawn
    public float spawnRate = 5; 
    public float timer = 0;
    public float heightOffset = 5; // The vertical offset for cloud spawning
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }
    }
    void SpawnCloud()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(cloud, new Vector3(62, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
