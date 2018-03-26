using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sirenEffect : MonoBehaviour {

	[SerializeField] Light redLight;
    [SerializeField] Light blueLight;

    private Vector3 red; // to rotate ligth because c# will kill you otherwise^^
    private Vector3 blue;

    [SerializeField] int speed;

    // Update is called once per frame
    void Update () {
        red.y += speed * Time.deltaTime ;
        blue.y -= speed * Time.deltaTime;

        redLight.transform.eulerAngles = red;
        blueLight.transform.eulerAngles =blue;

    }
}
