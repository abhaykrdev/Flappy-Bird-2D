using UnityEngine;

public class CloudMovementScript : MonoBehaviour
{
    public float Speed = 2;
    public float Deadzone = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Speed) * Time.deltaTime;
        if (transform.position.x < -19)
        {
            Destroy(gameObject);
        }

    }
}
