using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sumung : MonoBehaviour
{
    private float r;
    private float g;
    private float b;
    public Image sumung;
    public bool introType;
    public bool turn;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        //sr = sumung.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (turn == false)
        {
            Appear();
        }
        else
        {
            Disappear();
        }
        //Debug.Log(r);
        
        

    }
    public void Appear()
    {

        
        if (introType == true)
        {
            if (r < 2)
            {
                r = r + Time.deltaTime;
                g = g + Time.deltaTime;
                b = b + Time.deltaTime;
                sumung.color = new Color(r, g, b);
                if (r > 1.8)
                {
                    turn = true;
                }

            }
            
        }
        else
        {
            if (r < 2)
            {
                r = r + Time.deltaTime;
                g = g + Time.deltaTime;
                b = b + Time.deltaTime;
                sumung.color = new Color(r, g, b);

            }
        }

        
    }
    public void Disappear()
    {
        
        if (introType == true)
        {
            if (r < 2)
            {
                r = r - Time.deltaTime;
                g = g - Time.deltaTime;
                b = b - Time.deltaTime;
                sumung.color = new Color(r , g , b );
            }

            if (time > 3.5)
            {
                SceneManager.LoadScene("Start");
            }

        }
     

    }
    /*IEnumerator delay()
    {

        yield return new WaitForSeconds(5f);
    }*/
}
