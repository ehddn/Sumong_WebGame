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
    public Button me;
    public AudioClip sound;
    private AudioSource audio;
    private Vector3 size;
    // Start is called before the first frame update
    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        size = transform.localScale;
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameMg.playing_cheonan = false;
        gameMg.playing_seoul = false;
        if (type == 0)
        {
            if (gameMg.seoulClear == true)
            {
                checkImg.gameObject.SetActive(true);
                me.interactable = false;
            }
        }
        else if (type == 1)
        {
            if (gameMg.cheonanClear == true)
            {
                checkImg.gameObject.SetActive(true);
                me.interactable = false;
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
        }
        else if (type == 1)
        {
            gameMg.playing_cheonan = true;
        }
        gameMg.turnAudio();
        SceneManager.LoadScene(nextScene);
    }
    public void OnTouch()
    {
        this.gameObject.transform.localScale =new Vector3 (1f, 1.5f, 0);
        audio.clip = sound;
        audio.Play();
    }
    public void OnTouchEnd()
    {
        this.gameObject.transform.localScale = size;
    }
}
