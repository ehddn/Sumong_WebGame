using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public int seoul_stage;
    public int cheonan_stage;
    public string user_name;
    public string user_phoneNum;
    public bool seoulClear;
    public bool cheonanClear;

    public bool playing_seoul;
    public bool playing_cheonan;

    private AudioSource audio;
    public AudioClip seoul_bgm;
    public AudioClip cheonan_bgm;

    public int cntRight;

    void Awake() //���� �ٲ� �ı����� ����
    {
        if (gameManager == null)
            gameManager = this;

        else if (gameManager != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }

    void Start()
    {
        audio = gameObject.GetComponent<AudioSource>();
        seoul_stage = 0;
        cheonan_stage = 0;
    }
    public void turnAudio()
    {
        if(playing_seoul==true)
        {
            audio.clip = seoul_bgm;
            audio.Play();
        }
        else if (playing_cheonan == true)
        {
            audio.clip = cheonan_bgm;
            audio.Play();
        }
    }

    void Update()
    {
        if(seoul_stage >= 9)
        {
            seoul_stage = 8;
        }

        if (cheonan_stage >= 7)
        {
            cheonan_stage = 6;
        }
    }
}
