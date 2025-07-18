using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float moveSpeed; // Speed at which the obstacle moves

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the obstacle downwards
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -15f) // If the obstacle goes off-screen
        {
            Destroy(gameObject); // Destroy the obstacle
        }
    }
}
