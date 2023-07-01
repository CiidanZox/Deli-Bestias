using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJSpawnOb : MonoBehaviour
{
    public GameObject obstPrefab;      // Prefab del objeto enemigo
    public float spawnInterval = 12f;    // Intervalo de tiempo inicial entre spawns
    public float spawnIntervalReduction = 1f;   // Reducción de spawnInterval después de 48 segundos
    public float timeToReduceInterval = 48f;    // Tiempo después del cual se reduce el spawnInterval

    private float nextSpawnTime;        // Tiempo del próximo spawn
    private float elapsedTime;          // Tiempo transcurrido desde el inicio del juego

    private void Start()
    {
        // Inicializar los tiempos
        nextSpawnTime = Time.time + spawnInterval;
        elapsedTime = 0f;
    }

    private void Update()
    {
        // Incrementar el tiempo transcurrido
        elapsedTime += Time.deltaTime;

        // Comprobar si es el momento de hacer el spawn
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject();  // Hacer el spawn de un objeto
            nextSpawnTime = Time.time + spawnInterval;  // Actualizar el tiempo del próximo spawn
        }

        // Comprobar si ha pasado el tiempo para reducir el spawnInterval
        if (elapsedTime >= timeToReduceInterval && spawnInterval > 3f)
        {
            spawnInterval -= spawnIntervalReduction;  // Reducir el spawnInterval
            elapsedTime = 0f;  // Reiniciar el tiempo transcurrido
        }
    }

    private void SpawnObject()
    {
        float spawnX = Random.Range(-2.28f, 2.26f);
        Vector3 spawnPosition = new Vector3(spawnX, transform.position.y, 0f);

        Instantiate(obstPrefab, spawnPosition, Quaternion.identity);
    }
}
