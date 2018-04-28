
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    //Our Text : 
    public GameObject CountDown;
    //Our Start Fx:
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public AudioSource LevelMusic;
    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        //yield return new WaitForSeconds(0.5f);
        CountDown.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        CountDown.SetActive(false);

        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        CountDown.SetActive(false);
        CountDown.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        CountDown.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        

    }


}


