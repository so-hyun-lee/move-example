using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform target;
    SphericalCoordinates sphericalCoordinates;

    float rotateSpeed = 1f;
    float scrollSpeed = 200f;
    
    // Start is called before the first frame update
    void Start()
    {
        //±¸¸éÁÂÇ¥
        sphericalCoordinates = new SphericalCoordinates(transform.position);
        transform.position = sphericalCoordinates.ToCartesian + transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float h, v;
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        transform.position = sphericalCoordinates.Rotate(h * rotateSpeed * Time.deltaTime, v * rotateSpeed * Time.deltaTime).ToCartesian + target.position;
        
        transform.LookAt(target.position);
    }

}
