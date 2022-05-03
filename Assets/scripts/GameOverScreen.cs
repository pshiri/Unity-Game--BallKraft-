using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Canvas EscCan;
    public Canvas EscCan2;

    public void Restart()
    {


        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        KeepScore.Score = 0;

    }
    public void MainMenu()

    {
        EscCan.gameObject.SetActive(true);
        EscCan2.gameObject.SetActive(false);
        KeepScore.Score = 0;



    }



}