using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class StartSceneController : MonoBehaviour, IPointerClickHandler
{
    public TMP_InputField userNameBox;
    public TMP_InputField userPhoneNumBox;
    public Image raycastImg;
    public Image sumungImg;
    public Image changeSumung;
    //public WriteText mainText;
    



    //public Text textBox;
    public TMP_Text textBox;
    public List<Text> text;
    public string message;
    public int clickCnt = 0;
    public int nextClick = 0;
    public string nextScene;
    public float speed;

    //public string campus;

    public Coroutine col;


    // Start is called before the first frame update
    void Start()
    {
        //mainText = GameObject.Find("TextBackGround").GetComponent<WriteText>();
        message = text[clickCnt].text;
        col = StartCoroutine(Typing(textBox, message, speed,0));
        //TextBackGround.raycastTarget=false;

    }

    // Update is called once per frame
    void Update()
    {
        if (clickCnt == 2)
        {
            userNameBox.gameObject.SetActive(true);
            //userPhoneNumBox.gameObject.SetActive(true);
       

        }
        else if(clickCnt==3)
        {
            text[1].text= "호오.. 자네의 이름은 "+userNameBox.text+" 이군. 그렇다면 자네의 전화번호는 무엇인가?";
            
            DeleteBox();
            
            
        }
        else if (clickCnt == 5)
        {
            userPhoneNumBox.gameObject.SetActive(true);
        }
        else if (clickCnt == 6)
        {
            changeSumung.gameObject.SetActive(true);
            sumungImg.gameObject.SetActive(false);
            DeleteBox();
        }
    }
    public void DeleteBox()
    {
        userNameBox.gameObject.SetActive(false);
        userPhoneNumBox.gameObject.SetActive(false);
    }
    public IEnumerator Typing(TMP_Text textBox, string message, float speed,int num)
    {

        {
            message = text[num].text;
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
        //텍스트 타이핑 시작
        switch (clickCnt)
        {
            case 1:
                StopCoroutine(col);
                textBox.text = text[0].text;
                break;
            case 2:
                raycastImg.raycastTarget = false;
                break;
            case 4:
                StopCoroutine(col);
                textBox.text = text[1].text;

                //col = StartCoroutine(Typing(textBox, message, speed, 1));
                break;
            case 5:
                raycastImg.raycastTarget = false;
                //col = StartCoroutine(Typing(textBox, message, speed, 2));

                //textBox.text = text[2].text;
                break;
            case 6:
                //StopCoroutine(col);
                //textBox.text = text[3].text;
                
                
                break;


            case 7:
                col = StartCoroutine(Typing(textBox, message, speed, 3));
                break;
            case 8:
                StopCoroutine(col);
                textBox.text = text[3].text;

                break;
            case 9:
                SceneManager.LoadScene(nextScene);
                break;





        }
            

        /*if (clickCnt % 2 == 0)
        {
            col = StartCoroutine(Typing(textBox, message, speed));
        }
        //텍스트 타이핑을 멈추고 바로 출력
        else
        {
            StopCoroutine(col);
            textBox.text = text[clickCnt / 2].text;
        }*/



        /* Debug.Log("클릭");
         clickCnt++;
         StopCoroutine(col);
         textBox.text = message;*/


    }

    
}
