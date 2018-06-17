using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//each round has a series of questions
//a series of small pure C# classes - editable and display their values using the inspector
[System.Serializable]

public class QuestionData
{
    public string questionText;
    public AnswerData[] answers; //each question holds a number of answers associated with it and stored in data classes
}
