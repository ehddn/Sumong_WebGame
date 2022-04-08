using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ClearBtn : MonoBehaviour
{
    GameManager gameMg;
    public GameObject btn;
    public Image sumung;

    public AudioClip sound;
    
    private AudioSource audio;
    private Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameMg.audio.Stop();
        if ((gameMg.seoulClear == true) && (gameMg.cheonanClear == true))
        {
            btn.gameObject.SetActive(true);

        }
        audio = gameObject.GetComponent<AudioSource>();
        size = sumung.rectTransform.localScale;
    }
    public void Onclick()
    {
        gameMg.turnAudio();
        SceneManager.LoadScene("MoveToEasterEggAvoid");

        /*if (gameMg.cntRight <= 24)
        {
            gameMg.turnAudio();
            SceneManager.LoadScene("MoveToEasterEggAvoid");
        }*/
        /*else
        {
            gameMg.turnAudio();
            SceneManager.LoadScene("MoveToEasterEggPuzzle");
            //SceneManager.LoadScene("Ending");
            //SceneManager.LoadScene("Ending");
        }*/

    }
    // Update is called once per frame
    void Update()
    {
        
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
