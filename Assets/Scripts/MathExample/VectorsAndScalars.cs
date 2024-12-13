using System;
using Unity.Mathematics;
using UnityEngine;

public class VectorsAndScalars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;
        transform.rotation = Quaternion.Euler(80, 90, 57);
        
        Vector2 position2D = new Vector2(3, 4);

        Vector3 test = position2D;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
