using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultImage : MonoBehaviour
{
    private float r;
    private float g;
    private float b;
    public Image sumung;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        Appear();
        if(time>2.0f)
        {
            this.gameObject.SetActive(false);
        }

        //Debug.Log(r);

    }
    public void Appear()
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
