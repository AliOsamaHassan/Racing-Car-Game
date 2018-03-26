
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryMove : MonoBehaviour {

    
    public GameObject wheel_frontRight;
    public GameObject wheel_frontLeft;
    public GameObject wheel_backRight;
    public GameObject wheel_backLeft;

    public WheelCollider W_FR;
    public WheelCollider W_FL;
    public WheelCollider W_BR;
    public WheelCollider W_BL;

    public float speed=1000f;
    public float lowestSpeed = 20f;
    public float lowestAngel = 70f;
    public float highesAngel = 40f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        carMove();
    }

void carMove()
    {
        W_BL.motorTorque = speed * Input.GetAxis("Vertical");
        W_BL.motorTorque = speed * Input.GetAxis("Vertical");

        float speedFactor = this.GetComponent<Rigidbody>().velocity.magnitude / lowestSpeed;
        float currentAngle = Mathf.Lerp(lowestAngel, highesAngel, speedFactor);
        currentAngle *= Input.GetAxis("Horizontal");
        currentAngle *= Input.GetAxis("Horizontal");

        W_FL.steerAngle = currentAngle;
        W_FR.steerAngle = currentAngle;
    }
    
}