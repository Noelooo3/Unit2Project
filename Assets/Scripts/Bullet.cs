using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _velocity = 3.0f;
    private Vector2 _direction;

    private int _damage = 5;

    public void Fire(Vector2 direction)
    {
        _direction = direction;
    }
        
    private void Update()
    {
        transform.Translate(_direction * _velocity * Time.deltaTime);
    }
    
    // This will happen when the bullet hits something
    private void OnTriggerEnter2D(Collider2D other)
    {
        IDamageable objectGetHit = other.GetComponent<IDamageable>();
        if (objectGetHit != null)
        {
            objectGetHit.OnTakeDamage(_damage);
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
