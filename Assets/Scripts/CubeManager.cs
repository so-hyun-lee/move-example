using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public float speed;
    Vector3 targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        //Vector3 v1 = new Vector3(1, 1, 0);
        //transform.position = v1;
        //targetPosition = -Vector3.one;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                targetPosition = hit.point;
                Debug.Log($"Target Position: {targetPosition}");
            }
        }

        Vector3 dir = targetPosition  -transform.position;

        speed = 20f;
        dir.Normalize();
        dir = new Vector3(dir.x, 0, dir.z);
        dir *= speed * Time.deltaTime;
        

        transform.position += dir;
    }
}
