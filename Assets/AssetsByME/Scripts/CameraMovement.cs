using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public GameObject TheCar;
    public float carx;
    public float cary;
    public float carz;

    void Update () {
        carx = TheCar.transform.eulerAngles.x;
        cary = TheCar.transform.eulerAngles.y;
        carz = TheCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(carx - carx, cary, carz-carz);  
    }
}
