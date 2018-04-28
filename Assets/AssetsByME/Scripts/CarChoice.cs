using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject normalbody;
    public GameObject police;
    public int CarImport;
    void Start () {
        CarImport = GlobalCar.CarTyp;
        if(CarImport == 1)
        {
            normalbody.SetActive(false);
            police.SetActive(false);
            RedBody.SetActive(true);
        }
        if (CarImport == 2)
        {
            police.SetActive(false);
            normalbody.SetActive(false);
            RedBody.SetActive(false);
            BlueBody.SetActive(true);
        }
        if (CarImport == 3)
        {
            normalbody.SetActive(false);
            RedBody.SetActive(false);
            BlueBody.SetActive(false);
            police.SetActive(true);
        }
    }
	
}
