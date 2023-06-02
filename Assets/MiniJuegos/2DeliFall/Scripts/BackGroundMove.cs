using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    private Renderer rend;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void Update()
    {
        float offset = Time.time * moveSpeed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0f, -offset));
    }
}
