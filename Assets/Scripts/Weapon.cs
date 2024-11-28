using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    
    public void Fire(Vector2 direction)
    {
        Bullet bullet = Instantiate(_bulletPrefab, this.transform.position, quaternion.identity);
        bullet.Fire(direction);
    }
}
