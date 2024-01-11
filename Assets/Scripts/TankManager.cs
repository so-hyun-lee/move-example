using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{
    [SerializeField] GameObject tank;

    float newAngle = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            Debug.Log($"Mouse Position x:{Input.mousePosition.x} , y:{Input.mousePosition.y}");

            Vector3 tankScreenPoint = Camera.main.WorldToScreenPoint(tank.transform.position);

            Debug.Log($"Tank Position x:{tankScreenPoint.x}, y:{tankScreenPoint.y}");

            Vector3 diff = Input.mousePosition - tankScreenPoint;

            float angle = Mathf.Atan2(diff.y, diff.x) *  Mathf.Rad2Deg;
            newAngle = 90 - angle;
        }
        tank.transform.eulerAngles = new Vector3(0f, Mathf.LerpAngle(tank.transform.eulerAngles.y, newAngle, Time.deltaTime * 4f), 0f);
    }

}
