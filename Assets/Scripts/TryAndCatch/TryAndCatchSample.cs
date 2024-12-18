using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TryAndCatchSample : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    
    // Start is called before the first frame update
    void Start()
    {
        // Example 1
        try
        {
            Debug.Log("First");
            _text.text = "Hello World!";
            Debug.Log("Second");
        }
        catch (UnityException exception)
        {
            Debug.Log("Unity Exception: " + exception);
        }
        catch (Exception exception)
        {
            Debug.Log(exception);
        }

        Debug.Log("We are here!");
        
        // Example 2
        // int a = 10;
        // int b = 0;
        // int c = a / b;

        int a = 10;
        int b = 0;
        
        try
        {
            int c = a / b;
        }
        catch (Exception e)
        {
            Debug.Log(a);
            Debug.Log(b);
            Debug.Log("Exception: " + e);
        }
        
        // Most use case in the real life
        // Example 3
        // try
        // {
        //     // Connect to a server (Failed, server return an error)
        //     // Use data from the server to do something
        // }
        // catch (Exception exception)
        // {
        //     // Maybe try to reconnect to the server
        //     // Maybe use a fallback data
        // }
        
        // Do more things
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
