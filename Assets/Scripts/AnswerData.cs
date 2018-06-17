using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//holds answers to the questions
//a series of small pure C# classes - editable and display their values using the inspector
[System.Serializable]
public class AnswerData {
    public string answerText;
    public bool isCorrect;
}
