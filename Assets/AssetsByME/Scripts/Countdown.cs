
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public GameObject CountDown;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
   // public GameObject CarControls;

    // trun on sound sabek and la7ek in the start of the gaem
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
        yield return new WaitForSeconds(0.5f);
        CountDown.SetActive(false);

        CountDown.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown.SetActive(true);
        yield return new WaitForSeconds(0.5f);
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
