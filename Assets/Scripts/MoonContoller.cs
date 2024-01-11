using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonContoller : MonoBehaviour
{
    float euler;

    // Start is called before the first frame update
    void Update()
    {
        euler += Time.deltaTime;
        transform.position = GetPosition(euler * 100, 3);
    }

    Vector3 GetPosition(float angle,float radius)
    {
        float x = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
        float z = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
        

        return new Vector3(x,0,z);
    }


}
