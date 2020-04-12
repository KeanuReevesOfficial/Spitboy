using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAndShoot : MonoBehaviour
{
    public GameObject crosshairs;
    Vector3 target;


    void Update()
    {
        target = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3
        (-Input.mousePosition.x, -Input.mousePosition.y, transform.position.z));
    
        crosshairs.transform.position = target;
    }
}
