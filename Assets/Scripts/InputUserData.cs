using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InputUserData : MonoBehaviour
{
    GameManager gameMg;
    public Text warrningText;
    public string user_name;
    public Image raycastImg;
    StartSceneController startScene;
    //public string user_phoneNum;
    
    public TMP_InputField input_userName;
    public GameObject test;
    //public TMP_InputField input_userPhoneNum;


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
        user_name = input_userName.text;
    }
    public void WriteEnd()
    {
        if (user_name == "")
        {
            warrningText.text = "어허, 정확히 입력하지 못할까!";
            
        }
        else
        {
            gameMg.user_name = input_userName.text;
            raycastImg.raycastTarget = true;
            startScene.clickCnt++;
            
            //test.gameObject.SetActive(false);
            

        }
        
        //gameMg.user_phoneNum = input_userPhoneNum.text;
    }
}
