using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponData data;
    [SerializeField] private string _targetTag = "Enemy";

    private void Start()
    {

        PlayerPrefs.SetString("Weapon Progress", JsonUtility.ToJson(data));

        string retrievingFromMemoryText = PlayerPrefs.GetString("Weapon Progress");
        data = JsonUtility.FromJson<WeaponData>(retrievingFromMemoryText);

    }
    public void Fire(Vector2 direction)
    {
        Bullet bullet = Instantiate(data._bulletPrefab, this.transform.position, quaternion.identity);
        bullet.Initialize(data._weaponDamage, data._weaponVelocity, _targetTag, data._weaponScore, data._expiryTime);
        bullet.Fire(direction);
    }
}
