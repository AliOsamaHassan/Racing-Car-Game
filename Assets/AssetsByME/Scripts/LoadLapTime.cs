using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {
    public int MinCount;
    public int SecCount;
    public float MilliConut;
    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MilliDisplay;
    // to show user left time in ( miniuts , seconds and milliseconds)
    void Start () {

        MinCount = PlayerPrefs.GetInt("MinSave");
        SecCount = PlayerPrefs.GetInt("SecSave");
        MilliConut = PlayerPrefs.GetFloat("MilliSave");

        MinDisplay.GetComponent<Text>().text = "" +MinCount+":";
        SecDisplay.GetComponent<Text>().text = "" +SecCount+".";
        MilliDisplay.GetComponent<Text>().text = ""+MilliConut;
    }

}
