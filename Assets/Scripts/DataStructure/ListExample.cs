using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public List<int> intList = new List<int>();
    
    public List<int> intList2 = new List<int> {1, 20, 32, 44, 57};
    
    public List<GameObject> gameObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        // access is the same as array
        int theFirstElement = intList2[0];
        int theThirdElement = intList2[2];
        
        intList2.Add(60);
        Debug.Log(intList2[5]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
