using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //load scenes

//manage all the data and supply the round data to the game controller when get to that scene
public class DataController : MonoBehaviour {
    public RoundData[] allRoundData;
    private PlayerProgress playerProgress;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject); //make the object persist on loading new scene and never gets destroyed 
        LoadPlayerProgress(); //get the high score
        SceneManager.LoadScene("MenuScreen");
	}

    public RoundData GetCurrentRoundData() {
        return allRoundData[0]; 
    }

    //submit at the end of the round, save highest the score if it breaks the record
    public void SubmitNewPlayerScore(int newScore) {
        if (newScore > playerProgress.highestScore) {
            playerProgress.highestScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighestPlayerScore() {
        return playerProgress.highestScore;
    }

    private void LoadPlayerProgress() {
        playerProgress = new PlayerProgress();
        if (PlayerPrefs.HasKey("highestScore")) {
            playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
        }
    }

    private void SavePlayerProgress() {
        PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    }
}
