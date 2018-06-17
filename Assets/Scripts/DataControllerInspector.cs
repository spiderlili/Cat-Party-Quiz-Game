using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //load scenes

//manage all the data and supply the round data to the game controller when get to that scene
public class DataControllerInspector : MonoBehaviour {
    public RoundData[] allRoundData;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject); //make the object persist on loading new scene and never gets destroyed 
        SceneManager.LoadScene("MenuScreen");
	}

    public RoundData GetCurrentRoundData() {
        return allRoundData[0]; 
    }

	// Update is called once per frame
	void Update () {
		
	}
}
