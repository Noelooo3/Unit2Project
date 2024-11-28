using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExample : MonoBehaviour
{
    public Queue<int> intQueue = new Queue<int>();
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            intQueue.Enqueue(i);
            // add 1,2,3,4,5
        }

        for (int i = 0; i < 5; i++)
        {
            intQueue.Dequeue();
            // remove 1,2,3,4,5
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
