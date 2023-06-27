using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate;
    public float maxXpos;

    public GameObject girl;

    void Start()
    {
        StartSpawningObstacles();
        StartSpawningGirl();
    }

    void Spawn()
    {
        float randomX = Random.Range(-maxXpos, maxXpos);

        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }

    void StartSpawningObstacles()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    public void StopSpawningObstacles()
    {
        CancelInvoke("Spawn");
    }

    void SpawnGirl()
    {
        if(GameManager.Instance.score % 10 == 0 && GameManager.Instance.score!= 0)
        {
            float randomX = Random.Range(-maxXpos, maxXpos);

            Vector2 spawnPos = new Vector2(randomX, transform.position.y);

            Instantiate(girl, spawnPos, Quaternion.identity);
        }

        
    }

    void StartSpawningGirl()
    {
        InvokeRepeating("SpawnGirl", 1f, spawnRate);
    }
}
