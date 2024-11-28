using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunEnemy : Enemy
{
    [SerializeField] private Weapon _weapon;
    // 5 bullets per second, 1 / 5 = 0.2
    [SerializeField] private float _rateOfFire = 0.2f; 
    
    public override float MovementSpeed { get; set; } = 1.5f;
    protected override float _attackRange { get; set; } = 2.0f;
    
    private float _currentRateOfFire = 0.2f;
    private float _conflict = 100f;

    public override void Attack()
    {
        _weapon.Fire(transform.up);
    }
    
    private void Update()
    {
        Vector3 playerPosition = _target.transform.position;
        Vector3 enemyPosition = transform.position;
        Vector3 direction = (playerPosition - enemyPosition).normalized;
        
        Move(direction, playerPosition);
        
        float distance = Vector3.Distance(playerPosition, enemyPosition);
        
        if (distance < _attackRange)
        {
            _currentRateOfFire -= Time.deltaTime;
            if (_currentRateOfFire <= 0)
            {
                Attack();
                _currentRateOfFire = _rateOfFire;
            }
        }
        
        // Clean up the code
        // if (distance >= _attackRange)
        //     return;
        // _currentRateOfFire -= Time.deltaTime;
        // if ((_currentRateOfFire > 0)) 
        //     return;
        // Attack();
        // _currentRateOfFire = _rateOfFire;
    }
}
