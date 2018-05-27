using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BtnNew ()
    {
        Debug.Log("New");
        SceneManager.LoadScene("NewGameScene");
    }

    public void BtnLoad()
    {
        Debug.Log("Load");
        SceneManager.LoadScene("LoadGameScene");
    }

    public void BtnOptions()
    {
        Debug.Log("Options");
        SceneManager.LoadScene("OptionsScene");
    }

    public void BtnExit()
    {
        Application.Quit();
    }
}
