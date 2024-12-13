using UnityEngine;

public class Trigonometry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Different math libraries
        // Unity build in
        //Mathf.Tan(45);
        
        // System math library
        // Math.Tan(45);
        // MathF.Tan(45);
        
        // Unity math for DOTS
        //math.tan(45);

        // 30 is the degree not the radians
        float wrongTanForAlpha = Mathf.Tan(30);
        //Debug.Log(wrongTanForAlpha);
        // 1 radian = pi / 180
        float tanForAlpha = Mathf.Tan(30 * Mathf.Deg2Rad);
        //Debug.Log(tanForAlpha);
        // Deg2Rad = 1 / Rad2Deg
        
        float angleForAlpha = Mathf.Atan(tanForAlpha) * Mathf.Rad2Deg;
        Debug.Log(angleForAlpha);
        float sideA = 1f;
        float sideB = 1.732f;
        float angleForAlpha2 = Mathf.Atan2(sideA, sideB) * Mathf.Rad2Deg;
        Debug.Log(angleForAlpha2);
        
        //Mathf.Sin()
        //Mathf.Asin()
        
        //Mathf.Cos()
        //Mathf.Acos()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
