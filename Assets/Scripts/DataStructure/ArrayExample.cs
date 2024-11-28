using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // Array of 5 int elements
    public int[] intArray = new int [5];
    
    // Array of 1,2,3,4,5
    public int[] intArray2 = new int[] {1, 20, 32, 44, 57};
    
    public GameObject[] gameObjects;

    private void Start()
    {
        // access the first one
        // Start from 0
        int theFirstElement = intArray2[0];
        Debug.Log(intArray2[0]);
        
        intArray2[0] = 100;
        Debug.Log(intArray2[0]);
        
        // Get the size for the array
        int size = intArray2.Length;
    }
}
