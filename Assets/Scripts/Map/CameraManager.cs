using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject player;
    private GameObject pointer;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        pointer = GameObject.FindGameObjectWithTag("Pointer");

        if(pointer != null)
        {
            transform.position = new Vector3(0, pointer.transform.position.y, -10);
        }
        else
        {
            transform.position = new Vector3(0, player.transform.position.y, -10);
        }
    }
}
