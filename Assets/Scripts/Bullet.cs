using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 _direction;

    public int _damage { get; private set; }
    public float _velocity { get; private set; }

    public string _targetTag { get; private set; }

    public float _expiryTime { get; private set; }

    public int _bulletScore { get; private set;}

    public Bullet(int damage, float velocity, string targetTag, int score, float expiryTime)
    {
        _damage = damage;
        _velocity = velocity;
        _targetTag = targetTag;
        _bulletScore = score;
        _expiryTime = expiryTime;
    }

    public void Initialize(int damage, float velocity, string targetTag, int score, float expiryTime)
    {
        _damage = damage;
        _velocity = velocity;
        _targetTag = targetTag;
        _bulletScore = score;
        _expiryTime = expiryTime;
    }

    public void Fire(Vector2 direction)
    {
        _direction = direction;
        Destroy(this.gameObject, _expiryTime);
    }
        
    private void Update()
    {
        transform.Translate(_direction * _velocity * Time.deltaTime);
    }
    
    // This will happen when the bullet hits something
    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable objectGetHit = other.GetComponent<IDamageable>();
        if (objectGetHit != null && _targetTag == other.gameObject.tag)
        {
            objectGetHit.OnTakeDamage(_damage, _bulletScore);
            Destroy(this.gameObject);
        }
    }

    // This will happen when the bullet is inside something
    // private void OnTriggerStay2D(Collider2D other)
    // {
    //     
    // }

    // This will happen when the bullet leaves something
    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     
    // }
}
