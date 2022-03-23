using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzleResultBoard : MonoBehaviour
{
    public string nextScene;
    GameManager gameMg;
    public int easterEgg;

    // Start is called before the first frame update
    void Start()
    {
        if (easterEgg == 1)
        {
            gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameMg.findPuzzle = "O";
        }
        
        StartCoroutine(moveNextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator moveNextScene()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(nextScene);
    }

}
