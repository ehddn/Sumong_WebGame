using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SeoulStageManager : MonoBehaviour
{
    public List<GameObject> wayPoint;
    public List<Sprite> charSprite;
    public List<string> sceneList;
    public GameObject way;

    public GameObject player;
    public GameObject lockPrefeb;
    public GameObject clearPrefeb;
    public GameObject list;
    public GameObject click;

    public GameObject pointerPrefab;

    public Sprite lockImage;
    public Sprite clearImage;

    void Start()
    {
        
        
            wayPoint = new List<GameObject>();
            player = GameObject.FindGameObjectWithTag("Player");

            for (int i = 0; i < way.transform.childCount; i++)
            {
                wayPoint.Add(way.transform.GetChild(i).gameObject);
            }

            for (int i = 0; i < wayPoint.Count; i++)
            {
                GameObject locker = Instantiate(lockPrefeb, list.transform) as GameObject;
                locker.transform.position = wayPoint[i].transform.position;
            }

            if (GameManager.gameManager.seoul_stage > 0)
            {
                GameObject pointer = Instantiate(pointerPrefab, wayPoint[GameManager.gameManager.seoul_stage - 1].transform.position, Quaternion.Euler(0, 0, 0));
                List<GameObject> pointerWay = new List<GameObject>();
                pointerWay.Add(wayPoint[GameManager.gameManager.seoul_stage - 1]);
                for (int i = 0; i < wayPoint[GameManager.gameManager.seoul_stage - 1].transform.childCount; i++)
                {
                    pointerWay.Add(wayPoint[GameManager.gameManager.seoul_stage - 1].transform.GetChild(i).gameObject);
                }
                pointerWay.Add(wayPoint[GameManager.gameManager.seoul_stage]);
                StartCoroutine(pointer.GetComponent<Pointer>().move(pointerWay));
            }
        
    }

    void Update()
    {
        player.transform.position = wayPoint[GameManager.gameManager.seoul_stage].transform.position;
        player.GetComponent<Image>().sprite = charSprite[GameManager.gameManager.seoul_stage];

        for(int i = 0; i < wayPoint.Count; i++)
        {
            if(i < GameManager.gameManager.seoul_stage)
            {
                list.transform.GetChild(i).gameObject.SetActive(true);
                list.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = clearImage;
            }
            else if(i > GameManager.gameManager.seoul_stage)
            {
                
                list.transform.GetChild(i).gameObject.SetActive(true);
                list.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = lockImage;
            }
            else
            {
                list.transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        if(GameManager.gameManager.seoul_stage == 0)
        {
            click.SetActive(true);
        }
        else
        {
            click.SetActive(false);
        }
    }

    public void OnPlayerClicked()
    {
        if(GameManager.gameManager.seoul_stage <= wayPoint.Count - 1)
        {
            SceneManager.LoadScene(sceneList[GameManager.gameManager.seoul_stage]);
        }
        else
        {
            GameManager.gameManager.seoul_stage = 0;
            GameManager.gameManager.cheonan_stage = 0;
            SceneManager.LoadScene("Cheonan");
        }
    }

    public void OnPageClicked()
    {
        Application.OpenURL("https://www.smu.ac.kr/ko/index.do");
    }
}
