using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuzzleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StopInput()
    {
        EventSystem.current.IsPointerOverGameObject();
        yield return new WaitForSeconds(2.0f);
    }
}
