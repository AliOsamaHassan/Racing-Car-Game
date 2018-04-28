using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour {
    public static int CarTyp;
    public GameObject TrackWindow;
    public void redCar()
    {
        CarTyp = 1;
        TrackWindow.SetActive(true);
    }
    public void blueCar()
    {
        CarTyp = 2;
        TrackWindow.SetActive(true);
    }
    public void policeCae()
    {
        CarTyp = 3;
        TrackWindow.SetActive(true);
    }
}
