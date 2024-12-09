using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : PickUp
{
    [SerializeField] private int amountOfHealthToIncrease;
    protected override void PickMeUp(Player playerReference)
    {
        //Increase health of the player
        playerReference.OnGetHealth(amountOfHealthToIncrease);
        Destroy(gameObject);

    }
}
