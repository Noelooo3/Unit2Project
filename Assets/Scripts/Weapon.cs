using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private int _weaponDamage = 5;
    [SerializeField] private float _weaponVelocity = 3.0f;
    [SerializeField] private string _targetTag = "Enemy";
    [SerializeField] private int _weaponScore = 10;
    [SerializeField] private float _expiryTime = 5f;
    
    public void Fire(Vector2 direction)
    {
        Bullet bullet = Instantiate(_bulletPrefab, this.transform.position, quaternion.identity);
        bullet.Initialize(_weaponDamage, _weaponVelocity, _targetTag, _weaponScore, _expiryTime);
        bullet.Fire(direction);
    }
}
