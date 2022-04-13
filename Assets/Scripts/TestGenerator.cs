using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TestGenerator : MonoBehaviour
{
    public List<GameObject> prefabList;
    public List<Sprite> resultList;

    public GameObject timer;
    public GameObject board;
    public GameObject gameTimer;
    public GameObject result;
    public bool start;

    private PlayerAvoid player;

    private float startTime;
    private float gameTime;

    private float a_plusTime;
    private float aTime;
    private float bTime;
    private float cTime;
    private float dTime;
    private float fTime;

    public string nextScene;
    GameManager gameMg;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerAvoid>();
        gameMg = GameObject.Find("GameManager").GetComponent<GameManager>();
        start = false;

        startTime = 3.5f;
        gameTime = 30.5f;

        a_plusTime = 4.0f;
        aTime = 3.5f;
        bTime = 3.1f;
        cTime = 2.8f;
        dTime = 2.6f;
        fTime = 2.2f;
    }

    
    void Update()
    {
        if(start)
        {
            if(startTime > 0.5)
            {
                startTime -= Time.deltaTime;
                timer.GetComponent<Text>().text = startTime.ToString("F0");
            }
            else
            {
                timer.SetActive(false);

                if (gameTime < 0.5)
                {
                    board.SetActive(true);
                    board.transform.GetChild(0).gameObject.SetActive(false);
                    board.transform.GetChild(1).GetComponent<Text>().text = player.score.ToString() + "점";
                    board.transform.GetChild(3).gameObject.SetActive(true);
                    board.transform.GetChild(4).gameObject.SetActive(true);
                    result.gameObject.SetActive(true);
                    if (player.score >= 1200)
                    {
                        result.GetComponent<Image>().sprite = resultList[0];
                        gameMg.score = "A+";

                    }
                    else if(player.score >= 1000)
                    {
                        result.GetComponent<Image>().sprite = resultList[1];
                        gameMg.score = "A";
                    }
                    else if (player.score >= 800)
                    {
                        result.GetComponent<Image>().sprite = resultList[2];
                        gameMg.score = "B";
                    }
                    else if (player.score >= 200)
                    {
                        result.GetComponent<Image>().sprite = resultList[3];
                        gameMg.score = "C";
                    }
                    else if (player.score >= -200)
                    {
                        result.GetComponent<Image>().sprite = resultList[4];
                        gameMg.score = "D";
                    }
                    else
                    {
                        result.GetComponent<Image>().sprite = resultList[5];
                        gameMg.score = "F";
                    }
                    start = false;
                    //Debug.Log("게임 끗");
                    gameMg.findAvoid = "O"+"재수강 학점: "+gameMg.score;

                    //StartCoroutine(moveNextScene());
                    //�� �� �� ���� ������ �Ѿ��
                }
                else
                {
                    gameTime -= Time.deltaTime;
                    gameTimer.GetComponent<Text>().text = gameTime.ToString("F0");

                    a_plusTime -= Time.deltaTime;
                    aTime -= Time.deltaTime;
                    bTime -= Time.deltaTime;
                    cTime -= Time.deltaTime;
                    dTime -= Time.deltaTime;
                    fTime -= Time.deltaTime;

                    if (a_plusTime < 0)
                    {
                        GameObject a_plus = Instantiate(prefabList[0]) as GameObject;
                        a_plus.transform.position = new Vector2(Random.Range(-6.0f, 6.5f), 4);
                        a_plusTime = Random.Range(2.0f, 4.0f);
                    }
                    if (aTime < 0)
                    {
                        GameObject a = Instantiate(prefabList[1]) as GameObject;
                        a.transform.position = new Vector2(Random.Range(-6.0f, 6.5f), 4);
                        aTime = Random.Range(2.0f, 4.0f);
                    }
                    if (bTime < 0)
                    {
                        GameObject b = Instantiate(prefabList[2]) as GameObject;
                        b.transform.position = new Vector2(Random.Range(-6.0f, 6.5f), 4);
                        bTime = Random.Range(2.0f, 4.0f);
                    }
                    if (cTime < 0)
                    {
                        GameObject c = Instantiate(prefabList[3]) as GameObject;
                        c.transform.position = new Vector2(Random.Range(-6.0f, 6.5f), 4);
                        cTime = Random.Range(2.0f, 4.0f);
                    }
                    if (dTime < 0)
                    {
                        GameObject d = Instantiate(prefabList[4]) as GameObject;
                        d.transform.position = new Vector2(Random.Range(-6.0f, 6.5f), 4);
                        dTime = Random.Range(2.0f, 4.0f);
                    }
                    if (fTime < 0)
                    {
                        GameObject f = Instantiate(prefabList[5]) as GameObject;
                        f.transform.position = new Vector2(Random.Range(-6.0f, 6.5f), 4);
                        fTime = Random.Range(2.0f, 4.0f);
                    }
                }
                
            }
        }
    }

    public void OnClicked()
    {
        start = true;
        board.SetActive(false);
    }

    public void moveNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void restartScene()
    {
        SceneManager.LoadScene("Avoid");
    }
}
