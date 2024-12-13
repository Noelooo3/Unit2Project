using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 a = new Vector2(1, 2);
        Vector2 b = new Vector2(3, 4);
        
        // Linear interpolation
        // the last value should be between 0 and 1
        Vector2 midPoint = Vector2.Lerp(a, b, 0.5f);

        Vector3 c = new Vector3(4, 5, 0);
        Vector3 d = new Vector3(6, 7, 5);
        // slerp
        Vector3 slerpPoint = Vector3.Slerp(c, d, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
