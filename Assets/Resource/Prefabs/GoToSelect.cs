using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToSelect : MonoBehaviour
{
    public void OnSelectClicked()
    {
        GameManager.gameManager.playing_seoul = false;
        GameManager.gameManager.playing_cheonan = false;
        SceneManager.LoadScene("SelectMap");
    }
}
