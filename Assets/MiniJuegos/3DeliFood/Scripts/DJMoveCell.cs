using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJMoveCell : MonoBehaviour
{
   private Rigidbody2D rb;
   private float direcX;
   private float vel = 35f;


   private void Start()
   {
      rb = GetComponent<Rigidbody2D>();
   }

   private void Update()
   {
      direcX = Input.acceleration.x * vel;
      transform.position = new Vector2(Math.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
   }

   private void FixedUpdate()
   {
      rb.velocity = new Vector2(direcX, 0f);
   }
}
