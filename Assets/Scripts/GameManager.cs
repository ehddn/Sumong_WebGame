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

    public AudioSource audio;
    public AudioClip seoul_bgm;
    public AudioClip cheonan_bgm;
    public AudioClip avoid_bgm;


    //certificate
    public int cntRight;
    public string findAvoid;
    public string findPuzzle;
    public string score;

    public bool findEasterEgg;

    
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
        findAvoid = "X";
        findPuzzle = "X";
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
        else
        {
            audio.clip = avoid_bgm;
            audio.Play();
        }
    }

    void Update()
    {
        /*if(seoul_stage > 8)
        {
            seoul_stage = 8;
            seoulClear = true;
        }

        if (cheonan_stage > 5)
        {
            cheonan_stage = 5;
            cheonanClear = true;
        }*/

        if (SceneManager.GetActiveScene().name == "Ending") 
        {
            audio.mute = true;
        }
    }


}
