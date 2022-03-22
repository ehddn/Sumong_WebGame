using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingText : MonoBehaviour
{
    public Text textBox;
    public string message;
    public float speed;

    Coroutine col;
    // Start is called before the first frame update
    void Start()
    {
        col = StartCoroutine(Typing(textBox, message, speed));
        //Invoke("col", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Typing(Text textBox, string message, float speed)
    {
        
        {
            //message = text[clickCnt / 2].text;
            for (int i = 0; i < message.Length; i++)
            {
                textBox.text = message.Substring(0, i + 1);
                yield return new WaitForSeconds(speed);

            }

        }
        

    }
}
