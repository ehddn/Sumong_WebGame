using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixPuzzle : MonoBehaviour
{
    public List<GameObject> puzzlePieces;
    public List<Vector2> randomPuzzlePos;
    private List<int> pieceList;
    public int correctCnt=0;
    public GameObject resultBoard;
    // Start is called before the first frame update
    void Start()
    {
        MixPieces();
    }

    // Update is called once per frame
    void Update()
    {
        if (correctCnt == 16)
        {
            resultBoard.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
    void MixPieces()
    {    

        for(int i = 0; i < puzzlePieces.Count; i++)
        {
            int type = Random.Range(1, 3);
            if (type == 1)
            {
                float randomX = Random.Range(-7, -4);
                float randomY = Random.Range(1.5f, -3);
                puzzlePieces[i].transform.position = new Vector2(randomX, randomY);
            }
            else if(type==2)
            {
                float randomX = Random.Range(4.5f, 7);
                float randomY = Random.Range(1.5f, -3);
                puzzlePieces[i].transform.position = new Vector2(randomX, randomY);
            }
            

        }
        
    }
    IEnumerator showResult()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
