using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverlay : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject YouWinText;
    public void Setup(bool won)
    {
        gameObject.SetActive(true);
        if (won)
        {
            YouWinText.SetActive(true);
        }
        else
        {
            GameOverText.SetActive(true);
        }
        Cursor.visible = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("LuisSample");
    }
}