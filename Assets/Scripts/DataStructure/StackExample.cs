using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    public Stack<int> intStack = new Stack<int>();
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            intStack.Push(i);
            // add 1,2,3,4,5
        }

        for (int i = 0; i < 5; i++)
        {
            intStack.Pop();
            // remove 5,4,3,2,1
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
