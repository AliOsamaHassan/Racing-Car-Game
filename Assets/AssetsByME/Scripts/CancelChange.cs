using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelChange : MonoBehaviour {
    // to cnange Camera Perspective      
    public GameObject NoramlCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;
    
	// Update is called once per frame
	void Update () {
        // if the user click on space the Perspective would be changed
        if (Input.GetKey(KeyCode.Space))
        {
            if(CamMode == 3)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            } StartCoroutine(ModeChange());

        }
	}
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0)
        {
            NoramlCam.SetActive(true);
            FPCam.SetActive(false);
            FarCam.SetActive(true);

        }
        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NoramlCam.SetActive(false);
            FPCam.SetActive(false);
        }
        if (CamMode == 2)
        {
            FPCam.SetActive(true);
            FarCam.SetActive(false);
            NoramlCam.SetActive(false);
        }
    }
}
