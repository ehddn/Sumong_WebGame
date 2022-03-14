using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultBoard : MonoBehaviour
{
    WriteQuizText quizText;
    public Text text;

    public AudioClip wrongBGM;
    public AudioClip correctBGM;
    AudioSource audioSource;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        quizText = GameObject.FindGameObjectWithTag("QuizText").GetComponent<WriteQuizText>();
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(ShowResultBoard(quizText.isRight));
    }
    IEnumerator ShowResultBoard(bool answer)
    {
        this.gameObject.SetActive(true);
        if (answer == true)
        {
            
            text.text = "정답!";
            audioSource.clip = correctBGM;
            audioSource.Play();

        }
        else
        {
            
            text.text = "오답!";
            audioSource.clip = wrongBGM;
            audioSource.Play();

        }
        
        yield return new WaitForSeconds(2.0f);
        this.gameObject.SetActive(false);
    }


}
