using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Transform leftWall;
    public Transform rightWall;

    private Vector3 mOffset;
    private float mZCoord;
    private Vector3 initialPos;
    private bool restrictHorizontalMovement = false;

    public void RestrictHorizontalMovement(bool restrict)
    {
        restrictHorizontalMovement = restrict;
    }

    private void Start()
    {
        initialPos = transform.position;
    }

    private void Update()
    {
        if (restrictHorizontalMovement)
        {
            float clampedX = Mathf.Clamp(transform.position.x, leftWall.position.x, rightWall.position.x);
            transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
        }
    }

    public void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    public void OnMouseDrag()
    {
        Vector3 targetPos = GetMouseWorldPos() + mOffset;
        targetPos.y = initialPos.y;

        if (restrictHorizontalMovement)
        {
            targetPos.x = Mathf.Clamp(targetPos.x, leftWall.position.x, rightWall.position.x);
        }

        transform.position = targetPos;
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
