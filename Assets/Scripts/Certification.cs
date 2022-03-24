using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Certification : MonoBehaviour
{
    public string month;
    public string date;
    /*public Text monthText;
    public Text dateText;
    public Text user_name;
    public Text user_phoneNum;
    public Text score;
    public Text avoid;
    public Text puzzle;
    public Text totalScore;*/

    public TMP_Text monthText;
    public TMP_Text dateText;
    public TMP_Text user_name;
    public TMP_Text user_phoneNum;
    public TMP_Text score;
    public TMP_Text avoid;
    public TMP_Text puzzle;
    public TMP_Text totalScore;

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
        score.text = score.text + gameMg.cntRight;
        avoid.text += gameMg.findAvoid;
        puzzle.text += gameMg.findPuzzle;
        if ((gameMg.findPuzzle == "O")&&(gameMg.cntRight==31))
        {
            totalScore.text += " A+";
        }
        else if((gameMg.findPuzzle == "O") && (gameMg.cntRight <= 27))
        {
            totalScore.text += " A";
        }
        else if ((gameMg.cntRight >= 20)&&(gameMg.cntRight <= 24))
        {
            totalScore.text += " B+";
        }
        else if ((gameMg.cntRight >= 15) && (gameMg.cntRight <= 19))
        {
            totalScore.text += " B";
        }
        else if ((gameMg.cntRight >= 10) && (gameMg.cntRight <= 14))
        {
            totalScore.text += " C";
        }
        else if ((gameMg.cntRight >= 1) && (gameMg.cntRight <= 9))
        {
            totalScore.text += " D";
        }
        else if ((gameMg.cntRight==0))
        {
            totalScore.text += " F";
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
