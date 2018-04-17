using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour {

	public void playGame()
    {
        SceneManager.LoadScene("RaceArea01");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
