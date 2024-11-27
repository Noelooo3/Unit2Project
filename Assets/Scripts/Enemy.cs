using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : InteractableObject
{
    public override float MovementSpeed { get; set; } = 1.5f;

    public override void Attack()
    {
        Debug.Log("Enemy is attacking");
    }
    
    public override void Move(Vector2 direction, Vector2 lookDirection)
    {
        
    }
}