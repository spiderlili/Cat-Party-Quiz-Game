using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AnswerButton : MonoBehaviour {

    public Text answerText; //store a reference to the button text to display answer string
    private AnswerData answerData;
    private GameController gameController;
	// Use this for initialization
	void Start () {
        gameController = FindObjectOfType<GameController>();
	}

    //pass in data
    public void Setup(AnswerData data) {
        answerData = data;
        answerText.text = answerData.answerText;
    }

    public void HandleClick() {
        gameController.AnswerButtonClicked(answerData.isCorrect);
    }
}
