using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJMove : MonoBehaviour
{
     public float speed = 5f;
    
        void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 newPosition = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0f, 0f);
            newPosition.x = Mathf.Clamp(newPosition.x, -10f, 10f);
            transform.position = newPosition;
        }
}
