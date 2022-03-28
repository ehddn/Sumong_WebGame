using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastMap : MonoBehaviour
{
    GameManager gameMg;
    public int type;

    // Start is called before the first frame update
    void Start()
    {
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (type == 0)
        {
            gameMg.seoulClear = true;
        }
        else if (type == 1)
        {
            gameMg.cheonanClear = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
