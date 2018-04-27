using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enviroment : MonoBehaviour {

    private string scene = "";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void  onSceneSelect(string scene)
    {
        
        this.scene = scene;  
    }
    public void select()
    {
        mainMenue.enviroment = scene;
    }
}
