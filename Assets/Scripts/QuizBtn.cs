using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizBtn : MonoBehaviour
{
    public int answer;
    //public int quizCount=0;
    public Text textBox;
    public List<string> text;
    WriteQuizText quizText;
    QuizController controller;


    // Start is called before the first frame update
    void Start()
    {
        quizText = GameObject.FindGameObjectWithTag("QuizText").GetComponent<WriteQuizText>();
        textBox.text = text[quizText.quizCnt];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnClick()
    {
        quizText.isQuiz = true;
        quizText.ClickBtn(answer);
    }
    public void UpdateText(int quizCount)
    {
        textBox.text = text[quizCount];
    }
}
