using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenue : MonoBehaviour {
    public static string enviroment = "RaceArea01";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void play()
    {
        SceneManager.LoadScene(enviroment);
    }
}
