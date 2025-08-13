using UnityEngine;

public class PipeSpawnnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate=4;
    public float timer=0;
    public float heightOffset=8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }
    void spawnPipe() 
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        // Calculate the right edge of the camera for 2D orthographic view
        float rightEdge = Camera.main.transform.position.x + Camera.main.orthographicSize * Camera.main.aspect;

        // Spawn just off the right edge
        float spawnX = rightEdge + 6f; // 2 units off-screen, adjust as needed

        Vector3 spawnPos = new Vector3(spawnX, Random.Range(lowestPoint, highestPoint), 0);
        Instantiate(pipe, spawnPos, transform.rotation);
    }
}
