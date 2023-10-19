using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector3 moveDirection;

    
    void Start()
    {
        PlayerMovement.Initial(this);
    }

    
  
    void Update()
    {
        transform.position += speed * Time.deltaTime * moveDirection;
    }

    public void SetMovementDirection(Vector2 direction)
    {
        moveDirection = direction;
    }
}
