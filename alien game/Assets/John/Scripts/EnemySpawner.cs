using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnedEnemy; // Enemy prefab to spawn
  public float timeToSpawn,spawnCountdown; // Timer for spawning

    void Start()
    {
        spawnCountdown = timeToSpawn;
    }

    void Update()
    {
        spawnCountdown -= Time.deltaTime;
        if(spawnCountdown <= 0)
        {
            spawnCountdown = timeToSpawn;
            Instantiate(spawnedEnemy, transform.position, transform.rotation);
        }
    }

    // Function to spawn enemies
   
}
