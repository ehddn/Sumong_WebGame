using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MixPuzzle : MonoBehaviour
{
    public List<GameObject> puzzlePieces;
    public List<Vector2> randomPuzzlePos;
    public Image resultImage;
    private List<int> pieceList;
    public int correctCnt=0;
    public GameObject resultBoard;
    public GameObject pieces;
    //public GameObject backBoard;
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
            StartCoroutine(showResult());
        }
    }
    void MixPieces()
    {    

        for(int i = 0; i < puzzlePieces.Count; i++)
        {
            int type = Random.Range(1, 3);
            if (type == 1)
            {
                float randomX = Random.Range(-7f, -6.5f);
                float randomY = Random.Range(-1.5f, 2.8f);
                puzzlePieces[i].transform.position = new Vector2(randomX, randomY);
                puzzlePieces[i].GetComponent<DragAndDrop>().spawnPos = new Vector2(randomX, randomY);
            }
            else if(type==2)
            {
                float randomX = Random.Range(5.5f, 6f);
                float randomY = Random.Range(-1.5f, 2.8f);
                puzzlePieces[i].transform.position = new Vector2(randomX, randomY);
            }
            

        }
        
    }
    IEnumerator showResult()
    {
        resultImage.gameObject.SetActive(true);
        pieces.gameObject.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        resultBoard.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
