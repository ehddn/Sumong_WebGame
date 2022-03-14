using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //타이머 관련
    public Text timeText;
    public float time;

    //sprite 

    //public SpriteRenderer PuzzleBack;
    public GameObject puzzle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        
        timeText.text = Mathf.Ceil(time).ToString();

        if (time < 0)
        {
            //PuzzleBack.gameObject.SetActive(true);
            puzzle.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }


}
