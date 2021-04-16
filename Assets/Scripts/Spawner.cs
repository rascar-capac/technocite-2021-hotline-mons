using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<Transform> spawnPositions = null;
    public GameObject enemyPrefab = null;
    public float spawnPeriod;
    private float _nextSpawnTime;

    private void Start()
    {
        _nextSpawnTime = 0f;
    }

    private void Update()
    {
        if (Time.time >= _nextSpawnTime)
        {
            SpawnEnemy();

            _nextSpawnTime = Time.time + spawnPeriod;
        }
    }

    private void SpawnEnemy()
    {
        Vector3 randomPosition = spawnPositions[Random.Range(0, spawnPositions.Count)].position + Vector3.up;
        Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
    }
}
