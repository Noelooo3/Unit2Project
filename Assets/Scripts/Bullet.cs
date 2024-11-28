using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int _damage = 5;
    
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
