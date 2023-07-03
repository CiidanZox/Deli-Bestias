using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJSpawnManager : MonoBehaviour
{
    public GameObject pinaPrefab;
    public GameObject zanahoriaPrefab;
    public float spawnInterval = 2f;
    public float rotationSpeed = 100f;

    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void SpawnObject()
    {
        float spawnX = Random.Range(-2.28f, 2.26f);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0f);

        int randomIndex = Random.Range(0, 2);

        GameObject objectToSpawn;
        if (randomIndex == 0)
        {
            objectToSpawn = pinaPrefab;
        }
        else
        {
            objectToSpawn = zanahoriaPrefab;
        }
        
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
        
        Rigidbody2D rb = spawnedObject.GetComponent<Rigidbody2D>();
        rb.angularVelocity = rotationSpeed;
        
    }
}
