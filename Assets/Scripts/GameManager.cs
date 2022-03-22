using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;

    public int seoul_stage;
    public int cheonan_stage;
    public string user_name;
    public string user_phoneNum;



    void Awake() //���� �ٲ� �ı����� ����
    {
        if (gameManager == null)
            gameManager = this;

        else if (gameManager != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

    }

    void Start()
    {
        seoul_stage = 0;
        cheonan_stage = 0;
    }


    void Update()
    {
        if(seoul_stage >= 9)
        {
            seoul_stage = 8;
        }
    }
}
