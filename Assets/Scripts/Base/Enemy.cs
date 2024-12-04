using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : InteractableObject
{
    public EnemyType enemyType;
    public int valueOfScore = 10;
    
    protected abstract float _attackRange { get; set; }
    
    protected Player _target;
    private float _angleOffset = -90f;
    
    public override void Move(Vector2 direction, Vector2 lookDirection)
    {
        // Rotate the enemy to face the player
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle += _angleOffset;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        var distance = Vector2.Distance(_target.transform.position, this.transform.position);

        // Still too far, keep walking
        if (distance > _attackRange)
        {
            // Vector2.up = (0, 1)
            transform.Translate(Vector2.up * MovementSpeed * Time.deltaTime);
        }
    }

    private void Start()
    {
        // We might want to change this, but for now, we'll just find the player
        _target = FindObjectOfType<Player>();
    }

    public override void OnTakeDamage(int damage, int score)
    {
        GameManager._instance._scoreManager.AddScore(score);
        Debug.Log("score: " + score);
        Die();
    }

    public override void Die()
    {
        Destroy(this.gameObject);
        // Add score in the future
    }
}