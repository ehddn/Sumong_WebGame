using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class InputUserData : MonoBehaviour
{
    GameManager gameMg;
    public string user_name;
    public string user_phoneNum;
    
    public TMP_InputField input_userName;
    public TMP_InputField input_userPhoneNum;



    TextMeshProUGUI resourceText;

    // Start is called before the first frame update
    void Start()
    {
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void Writing()
    {

    }
    public void WriteEnd()
    {
        gameMg.user_name = input_userName.text;
        gameMg.user_phoneNum = input_userPhoneNum.text;
    }
}
