using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.attachedRigidbody.CompareTag("Player"))
        {
            //Pick Up
            Player playerOnTrigger = collision.attachedRigidbody.GetComponent<Player>();
            PickMeUp(playerOnTrigger);
        }
    }

    protected abstract void PickMeUp(Player playerReference);
}
