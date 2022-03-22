using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sumung : MonoBehaviour
{
    private float r;
    private float g;
    private float b;
    public Image sumung;

    // Start is called before the first frame update
    void Start()
    {
        //sr = sumung.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        r = r + Time.deltaTime;
        g = g + Time.deltaTime;
        b = b + Time.deltaTime;
        Appear();

    }
    public void Appear()
    {
        if (r < 255)
        {
            sumung.color = new Color(r, g, b);
        }

        
    }
    /*IEnumerator delay()
    {

        yield return new WaitForSeconds(5f);
    }*/
}
