using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class WriteQuizText : MonoBehaviour
{
    public Text textBox;
    public List<Text> text;
    public List<int> answerList;
    private string message;
    public int quizCnt = 0;
    public string nextScene;
    public bool isQuiz=false;
    public bool isRight = false;
    public float speed;
    public int lastQuiz;


    //정답 버튼
    QuizBtn btn1;
    QuizBtn btn2;
    QuizBtn btn3;
    QuizBtn btn4;

    //결과보드
    public GameObject resultBoard;

    Coroutine col;

    // Start is called before the first frame update
    void Start()
    {
        col = StartCoroutine(delay(textBox, message, speed, quizCnt,0));
        btn1 = GameObject.Find("Answer1").GetComponent<QuizBtn>();
        btn2 = GameObject.Find("Answer2").GetComponent<QuizBtn>();
        btn3 = GameObject.Find("Answer3").GetComponent<QuizBtn>();
        btn4 = GameObject.Find("Answer4").GetComponent<QuizBtn>();
        //resultBoard = GameObject.Find("ResultBoard").GetComponent<ResultBoard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Typing(Text textBox, string message, float speed, int QuizCnt)
    {    
        {
            message = text[quizCnt].text;
            for (int i = 0; i < message.Length; i++)
            {
                textBox.text = message.Substring(0, i + 1);
                yield return new WaitForSeconds(speed);
            }
            
        }
    }

    IEnumerator delay(Text textBox, string message, float speed, int QuizCnt, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        LoadnextScene();
        StartCoroutine(Typing(textBox, message, speed, quizCnt));
        
    }

    public void ClickBtn(int answer)
    {
        
        
        if (answer == answerList[quizCnt])
        {
            Debug.Log("정답!");
            isRight = true;
            resultBoard.SetActive(true);
            quizCnt++;
            
            col = StartCoroutine(delay(textBox, message, speed, quizCnt,2.0f));
            
            btn1.UpdateText(quizCnt);
            btn2.UpdateText(quizCnt);
            btn3.UpdateText(quizCnt);
            btn4.UpdateText(quizCnt);
           


        }
        else
        {
            Debug.Log("오답!");
            isRight = false;
            resultBoard.SetActive(true);
            quizCnt++;
            
            col = StartCoroutine(delay(textBox, message, speed, quizCnt,2.0f));
            
            btn1.UpdateText(quizCnt);
            btn2.UpdateText(quizCnt);
            btn3.UpdateText(quizCnt);
            btn4.UpdateText(quizCnt);
           
        }
        


  
    }
    public void LoadnextScene()
    {
        if(quizCnt==lastQuiz)
        {
            SceneManager.LoadScene(nextScene);
        }
    }

    


}
