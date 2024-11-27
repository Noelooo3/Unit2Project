using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : InteractableObject
{
    public override float MovementSpeed { get; set; } = 2.5f;
    
    [SerializeField] private Camera _camera;
    
    private void Start()
    {
        _health = new Health(100, 90);
    }

    public override void Attack()
    {
        Debug.Log("Player is attacking");
    }

    public override void Move(Vector2 direction, Vector2 lookDirection)
    {
        var playerPositionInScreen = _camera.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(lookDirection.y - playerPositionInScreen.y, lookDirection.x - playerPositionInScreen.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
    }
}
