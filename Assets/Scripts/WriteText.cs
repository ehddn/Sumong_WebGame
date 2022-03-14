using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class WriteText : MonoBehaviour,IPointerClickHandler
{
    public Text textBox;
    public List<Text> text;
    private string message;
    public int clickCnt=0;
    public int nextClick = 0;
    public string nextScene;
    public float speed;

    Coroutine col;

    // Start is called before the first frame update
    void Start()
    {
        //첫번째 텍스트 출력
        message = text[clickCnt].text;
        col =StartCoroutine(Typing(textBox, message, speed));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Typing(Text textBox,string message,float speed)
    {
        
        {
            message = text[clickCnt / 2].text;
            for (int i = 0; i < message.Length; i++)
            {
                textBox.text = message.Substring(0, i + 1);
                yield return new WaitForSeconds(speed);
                
            }
            
        }
        clickCnt++;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        clickCnt++;
        if (clickCnt == nextClick)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            //텍스트 타이핑 시작
            if (clickCnt % 2 == 0)
            {
                col = StartCoroutine(Typing(textBox, message, speed));
            }
            //텍스트 타이핑을 멈추고 바로 출력
            else
            {
                StopCoroutine(col);
                textBox.text = text[clickCnt / 2].text;
            }
        }

        

        /* Debug.Log("클릭");
         clickCnt++;
         StopCoroutine(col);
         textBox.text = message;*/
        

    }
    
}
