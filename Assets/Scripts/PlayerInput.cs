using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    // To help out between Update and FixedUpdate
    private float _horizontal;
    private float _vertical;
    private Vector2 _lookDirection;
    
    // This happens every frame
    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        _lookDirection = Input.mousePosition;
    }

    // This happens at a fixed interval
    private void FixedUpdate()
    {
        _player.Move(new Vector2(_horizontal, _vertical), _lookDirection);
    }
}
