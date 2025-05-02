using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    private GameObject newEnemy;
    private SpriteRenderer rend;
    private int randomSpawnZone;
    private float randomXposition, randomYposition;
    private Vector3 spawnPosition;

    [SerializeField] Vector2 minPosition, maxPosition;

    void Start()
    {
        InvokeRepeating("SpawnNewEnemy", 0f, 2f);
    }
    private void SpawnNewEnemy()
    {
        randomSpawnZone = Random.Range(0, 4);

        switch (randomSpawnZone)
        {
            case 0:
                randomXposition = Random.Range(minPosition.x, maxPosition.x);
                randomYposition = Random.Range(minPosition.y, maxPosition.y);
                break;
            //case 1:
            //    randomXposition = Random.Range(-10f, 10f);
            //    randomYposition = Random.Range(-7f, -8f);
            //    break;
            //case 2:
            //    randomXposition = Random.Range(10f, 11f);
            //    randomYposition = Random.Range(-8f, 8f);
            //    break;
            //case 3:
            //    randomXposition = Random.Range(-10f, 10f);
            //    randomYposition = Random.Range(7f, 8f);
            //    break;
        }

        spawnPosition = new Vector3(randomXposition, randomYposition, 0f);
        newEnemy = Instantiate(enemy, spawnPosition, Quaternion.identity);
        //rend = newEnemy.GetComponent<SpriteRenderer>();
        //rend.color = new Color(Random.Range(0, 2), Random.Range(0, 2), Random.Range(0, 2), 1f);
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(new Vector3((minPosition.x + maxPosition.x) / 2, (minPosition.y + maxPosition.y) / 2, 0), new Vector3(maxPosition.x - minPosition.x, maxPosition.y - minPosition.y, 0));
    }
}
