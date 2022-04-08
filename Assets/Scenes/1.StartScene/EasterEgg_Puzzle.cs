using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasterEgg_Puzzle : MonoBehaviour
{
    public string nextScene;
    GameManager gameMg;

    // Start is called before the first frame update
    void Start()
    {
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
        if (gameMg.findEasterEgg == true)
        {
            this.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Onclick()
    {
        gameMg.findEasterEgg = true;
        SceneManager.LoadScene(nextScene);
    }
}
