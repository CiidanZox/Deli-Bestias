using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
   public GameObject circlePrefab;
   public float spawnInterval = 3f;
   public float spawnSpeed = 2f;
   public float spawnHeight = -5f;
   public float spawnX1 = -1.5f;
   public float spawnX2 = 1.5f;
   public float speedIncrementInterval = 10f;
   public float speedIncrementAmount = 1f;

   private float timer = 0f;
   private float speedTimer = 0f;
   private bool alternateSpawn = false;

   private void Update()
   {
      timer += Time.deltaTime;
      speedTimer += Time.deltaTime;

      if (timer >= spawnInterval)
      {
         SpawnCircle();
         timer = 0f;
         alternateSpawn = !alternateSpawn;
      }

      if (speedTimer >= speedIncrementInterval)
      {
         spawnSpeed += speedIncrementAmount;
         speedTimer = 0f;
      }
   }

   private void SpawnCircle()
   {
      float spawnX = Random.Range(spawnX1, spawnX2);

      GameObject circle = Instantiate(circlePrefab, transform.position + new Vector3(spawnX, spawnHeight, 0f), Quaternion.identity);
      Rigidbody2D circleRb = circle.GetComponent<Rigidbody2D>();
      if (circleRb != null)
      {
         circleRb.velocity = new Vector2(0f, spawnSpeed);
      }
   }
 
}
