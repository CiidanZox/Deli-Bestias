using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJSpawnManager : MonoBehaviour
{
    public GameObject coinPrefab;      // Prefab del objeto moneda// Prefab del objeto obstáculo
    public float spawnInterval = 2f;    // Intervalo de tiempo entre spawns

    private float nextSpawnTime;        // Tiempo del próximo spawn

    private void Start()
    {
        // Inicializar el tiempo del próximo spawn
        nextSpawnTime = Time.time + spawnInterval;
    }

    private void Update()
    {
        // Comprobar si es el momento de hacer el spawn
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();  // Hacer el spawn de un objeto
            nextSpawnTime = Time.time + spawnInterval;  // Actualizar el tiempo del próximo spawn
        }
    }

    private void SpawnObject()
    {
        float spawnX = Random.Range(-2.28f, 2.26f);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0f);
        
        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
