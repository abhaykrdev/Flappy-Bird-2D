using UnityEngine;

public class BoundaryScript : MonoBehaviour
{
    public LogicManager logic;
    public bool birdIsAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            logic.gameOver();
            collision.gameObject.GetComponent<BirdScript>().birdIsAlive = false;
            logic.playDieSound();
        }
    }
}
