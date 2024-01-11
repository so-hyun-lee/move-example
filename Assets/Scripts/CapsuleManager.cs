using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleManager : MonoBehaviour
{
    [SerializeField] GameObject capsule1;
    [SerializeField] GameObject capsule2;
    [SerializeField] GameObject capsule3;
    float value = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        value += Time.deltaTime * 200f;

        float sinWave = Mathf.Sin(Mathf.Deg2Rad * value);
        float cosWave = Mathf.Cos(Mathf.Deg2Rad * value);

        capsule1.transform.position = new Vector3(capsule1.transform.position.x, sinWave, capsule1.transform.position.z);
        capsule2.transform.position = new Vector3(capsule2.transform.position.x, cosWave, capsule2.transform.position.z );
        capsule3.transform.position = new Vector3(capsule3.transform.position.x, Mathf.Abs(sinWave), capsule3.transform.position.z );
    }
}
