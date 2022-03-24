using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SumungDance : MonoBehaviour
{
    public Image left;
    public Image right;
    public bool sw;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        left.gameObject.SetActive(false);
        right.gameObject.SetActive(true);
        InvokeRepeating("switchSumung", 0.5f,timer);
    }

    // Update is called once per frame
    void Update()
    {
       // StartCoroutine(SwitchImg());
    }
    public void switchSumung()
    {
        if (sw == true)
        {
            left.gameObject.SetActive(false);
            right.gameObject.SetActive(true);
            sw = false;
        }
        else
        {
            left.gameObject.SetActive(true);
            right.gameObject.SetActive(false);
            sw = true;
        }
    }
    IEnumerator SwitchImg()
    {
        yield return new WaitForSeconds(2f);
        if (sw == true)
        {
            left.gameObject.SetActive(false);
            right.gameObject.SetActive(true);
            sw = false;
        }
        else
        {
            left.gameObject.SetActive(true);
            right.gameObject.SetActive(false);
            sw = true;
        }

    }
}
