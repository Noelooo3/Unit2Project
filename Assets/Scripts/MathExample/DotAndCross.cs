using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotAndCross : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 a = new Vector2(1, 2);
        Vector2 b = Vector2.right; // (1, 0)

        float dotProduct = Vector2.Dot(a, b);

        Vector3 c = new Vector3(1,2,3);
        Vector3 d = new Vector3(4,5,6);
        
        // Cross product is a vector
        // Cross product will be perpendicular to both a and b
        Vector3 crossProduct = Vector3.Cross(c, d);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
