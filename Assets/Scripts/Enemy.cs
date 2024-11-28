using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : InteractableObject
{
    public override float MovementSpeed { get; set; } = 1.5f;

    private Player _target;
    private float _angleOffset = -90f;
    
    public override void Attack()
    {
        Debug.Log("Enemy is attacking");
    }
    
    public override void Move(Vector2 direction, Vector2 lookDirection)
    {
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle += _angleOffset;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        
        transform.Translate(direction * MovementSpeed * Time.deltaTime);
    }

    private void Start()
    {
        // We might want to change this, but for now, we'll just find the player
        _target = FindObjectOfType<Player>();
    }

    protected virtual void Update()
    {
        Vector3 playerPosition = _target.transform.position;
        Vector3 enemyPosition = transform.position;
        Vector3 direction = (playerPosition - enemyPosition).normalized;
        
        float distance = Vector3.Distance(playerPosition, enemyPosition);

        if (distance < 2f)
        {
            Attack();
        }
        else
        {
            Move(direction, playerPosition);
        }
    }
}