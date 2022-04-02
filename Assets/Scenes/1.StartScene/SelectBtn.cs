using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SelectBtn : MonoBehaviour
{
    GameManager gameMg;
    public string nextScene;
    public int type;
    public Image checkImg;
    public Image sumung;
    public Button btn;
    public AudioClip sound;
    private AudioSource audio;
    private Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        size = sumung.rectTransform.localScale;
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameMg.playing_cheonan = false;
        gameMg.playing_seoul = false;

        if (type == 0)
        {
            if (gameMg.seoulClear == true)
            {
                checkImg.gameObject.SetActive(true);
                btn.interactable = false;
            }
           
        }
        else if (type == 1)
        {
            if (gameMg.cheonanClear == true)
            {
                checkImg.gameObject.SetActive(true);
                btn.interactable = false;
            }
           
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if (type == 0)
        {
            gameMg.playing_seoul = true;
            //gameMg.seoul_stage = 0;
            //gameMg.cheonan_stage = 0;
            if (gameMg.seoul_stage == 9)
            {
                SceneManager.LoadScene("MoveToPuzzleSeoul");
            }
            else
            {
                SceneManager.LoadScene(nextScene);
            }
        }
        else if (type == 1)
        {
            gameMg.playing_cheonan = true;
            //gameMg.seoul_stage = 0;
            //gameMg.cheonan_stage = 0;
            if (gameMg.cheonan_stage == 6)
            {
                SceneManager.LoadScene("MoveToPuzzleCheonan");

            }
            else
            {
                SceneManager.LoadScene(nextScene);
            }
        }
        
        gameMg.turnAudio();
        //SceneManager.LoadScene(nextScene);
    }
    public void OnTouch()
    {
        sumung.gameObject.transform.localScale = size * 1.2f;
        audio.clip = sound;
        audio.Play();
    }
    public void OnTouchEnd()
    {
        sumung.gameObject.transform.localScale = size;
    }
}
