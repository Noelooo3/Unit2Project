using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class WeaponData : ScriptableObject
{
    public Bullet _bulletPrefab;
    public int _weaponDamage = 5;
    public float _weaponVelocity = 3.0f;
    public int _weaponScore = 10;
    public float _expiryTime = 5f;

}
