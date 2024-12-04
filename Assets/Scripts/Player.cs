using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : InteractableObject
{
    public override float MovementSpeed { get; set; } = 50f;
    
    [SerializeField] private Camera _camera;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    
    private float _angleOffset = -90f;

    [SerializeField] private Weapon _weapon;

    public static Action<float> OnHealthChanged;
    
    private void Start()
    {
        _health = new Health(100, 90);
    }

    public override void Attack()
    {
        Debug.Log("Player is attacking");
        _weapon.Fire(transform.up);
    }

    public override void Move(Vector2 direction, Vector2 lookDirection)
    {
        _rigidbody2D.velocity = direction * MovementSpeed * Time.deltaTime;
        
        Vector3 playerPositionInScreen = _camera.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(lookDirection.y - playerPositionInScreen.y, lookDirection.x - playerPositionInScreen.x) * Mathf.Rad2Deg;
        angle += _angleOffset;
        
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    public override void OnTakeDamage(int damage, int score = 0)
    {
        _health.TakeDamage(damage);
        OnHealthChanged?.Invoke(_health.CurrentHealth);
    }
    
    public override void Die()
    {
        Debug.Log("Player is dead");
    }

    public void Update()
    {
      if(Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }
}
