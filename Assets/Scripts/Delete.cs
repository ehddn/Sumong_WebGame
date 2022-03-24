using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    private float time;
    void Start()
    {
        time = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if(time < 0)
        {
            Destroy(this.gameObject);
        }
    }
}
