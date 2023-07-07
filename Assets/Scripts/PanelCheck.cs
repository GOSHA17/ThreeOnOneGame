using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelCheck : MonoBehaviour
{
    public InputField[] answers = new InputField[3];
    private string[] answer = new string[3];
    public Text[] answerText = new Text[3];
    public Toggle[] toggle;
    public Text[] textTitle;
    public Text[] title;
    public static int correctCount;
    
    void Start()
    {
        SetAnswers();
        correctCount = 0;
    }
    
    public void SetAnswers()
    {
        for (int i=0; i<3; i++)
        {
            answer[i] = answers[i].text;
            answerText[i].text = answer[i];
            textTitle[i].text = title[i].text;
        }
    }
    public void MathPoints()
    {
        for (int i=0; i<3; i++)
        {
            if (toggle[i].isOn == true)
            {
                correctCount++;
            }
        }
    }
}
