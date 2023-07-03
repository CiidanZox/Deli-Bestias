using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJSpawnOb : MonoBehaviour
{
    public GameObject obstPrefab;
    public float spawnInterval = 12f;
    public float spawnIntervalReduction = 1f;
    public float timeToReduceInterval = 48f;

    private float nextSpawnTime;
    private float elapsedTime;

    private void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
        elapsedTime = 0f;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnInterval;
        }
        
        if (elapsedTime >= timeToReduceInterval && spawnInterval > 3f)
        {
            spawnInterval -= spawnIntervalReduction;
            elapsedTime = 0f;
        }
    }

    private void SpawnObject()
    {
        float spawnX = Random.Range(-2.28f, 2.26f);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0f);

        Instantiate(obstPrefab, spawnPosition, Quaternion.identity);
    }
}
