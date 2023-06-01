using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject circlePrefab;
    public float spawnInterval = 3f;
    public float spawnSpeed = 2f;
    public float spawnHeight = -5f;
    public float spawnX1 = -1.5f;
    public float spawnX2 = 1.5f;

    private float timer = 0f;
    private bool alternateSpawn = false;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnCircle();
            timer = 0f;
            alternateSpawn = !alternateSpawn;
        }
    }

    private void SpawnCircle()
    {
        float spawnX = alternateSpawn ? spawnX1 : spawnX2;

        GameObject circle = Instantiate(circlePrefab, transform.position + new Vector3(spawnX, spawnHeight, 0f), Quaternion.identity);
        Rigidbody2D circleRb = circle.GetComponent<Rigidbody2D>();
        if (circleRb != null)
        {
            circleRb.velocity = new Vector2(0f, spawnSpeed);
        }
    }
}
