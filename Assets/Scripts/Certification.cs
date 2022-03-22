using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Certification : MonoBehaviour
{
    public string month;
    public string date;
    public Text monthText;
    public Text dateText;
    public Text user_name;
    public Text user_phoneNum;
    GameManager gameMg;

    // Start is called before the first frame update
    void Start()
    {
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();

        month=System.DateTime.Now.ToString("MM");
        date = System.DateTime.Now.ToString("dd");
        monthText.text =month;
        dateText.text = date;
        user_name.text = gameMg.user_name;
        user_phoneNum.text = gameMg.user_phoneNum;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
