using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputUserDataPhoneNum : MonoBehaviour
{
    GameManager gameMg;
    public Text warrningText;
    //public string user_name;
    public string user_phoneNum;
    public Image raycastImg;

    //public TMP_InputField input_userName;
    public TMP_InputField input_userPhoneNum;
    StartSceneController startScene;


    // Start is called before the first frame update
    void Start()
    {
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
        startScene = GameObject.Find("TextBackGround").GetComponent<StartSceneController>();
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Writing()
    {
        user_phoneNum = input_userPhoneNum.text;
    }
    public void WriteEnd()
    {
        if (user_phoneNum == "")
        {
            warrningText.text = "어허, 정확히 입력하지 못할까!";
        }
        else
        {
            raycastImg.raycastTarget = true;
            gameMg.user_phoneNum = input_userPhoneNum.text;
            startScene.clickCnt++;
            //input_userPhoneNum.gameObject.SetActive(false);
        }
        //gameMg.user_name = input_userName.text;
        
    }
}
