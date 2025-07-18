using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstacles; // Array of obstacle prefabs to spawn
    Vector3 spawnPosition; // Position where the obstacle will be spawned
    public float spawnInterval; // Time interval between spawns

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPosition = transform.position; // Set the spawn position to the current position of the spawner
    }

    // Update is called once per frame
    void Update()
    {
        int randomObstacle = Random.Range(0, obstacles.Length); // Get a random index for the obstacle array
    }
}
