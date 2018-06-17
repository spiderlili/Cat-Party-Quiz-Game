using System.Collections;
using UnityEngine;
//each round has a series of questions
//a series of small pure C# classes - editable and display their values using the inspector
[System.Serializable]

public class RoundData
{
    public string roundName;
    public int timeLimitSeconds; //how many seconds the player have to complete the round
    public int pointsAddedForRightAnswer; //how many points are awarded for right answer
    //each round holds a number of questions, each question holds a number of answers
    public QuestionData[] questions;
}
