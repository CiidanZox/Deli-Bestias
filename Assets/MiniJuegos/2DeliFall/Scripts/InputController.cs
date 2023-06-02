using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    private PlayerMove playerMove;

    private void Start()
    {
        playerMove = FindObjectOfType<PlayerMove>();
    }
    
    private void OnMouseDown()
    {
        playerMove.OnMouseDown();
    }

    private void OnMouseDrag()
    {
        playerMove.OnMouseDrag();
    }
}
