using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheonanStageManager : MonoBehaviour
{
    public List<GameObject> wayPoint;
    public List<Sprite> charSprite;
    public GameObject way;

    public GameObject player;
    public GameObject lockPrefeb;
    public GameObject clearPrefeb;
    public GameObject list;
    public GameObject click;

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
    }

    void Update()
    {
        player.transform.position = wayPoint[GameManager.gameManager.cheonan_stage].transform.position;
        player.GetComponent<Image>().sprite = charSprite[GameManager.gameManager.cheonan_stage];

        for (int i = 0; i < wayPoint.Count; i++)
        {
            if (i < GameManager.gameManager.cheonan_stage)
            {
                list.transform.GetChild(i).gameObject.SetActive(true);
                list.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = clearImage;
            }
            else if (i > GameManager.gameManager.cheonan_stage)
            {

                list.transform.GetChild(i).gameObject.SetActive(true);
                list.transform.GetChild(i).GetComponent<SpriteRenderer>().sprite = lockImage;
            }
            else
            {
                list.transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        if (GameManager.gameManager.cheonan_stage == 0)
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
        if (GameManager.gameManager.cheonan_stage < wayPoint.Count - 1)
        {
            GameManager.gameManager.cheonan_stage++;
        }
        else
        {
            GameManager.gameManager.cheonan_stage = 0;
            Application.OpenURL("https://www.smu.ac.kr/ko/index.do");
        }
    }

    public void OnPageClicked()
    {
        Application.OpenURL("https://www.smu.ac.kr/ko/index.do");
    }

}
