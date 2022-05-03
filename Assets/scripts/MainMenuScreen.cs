using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScreen : MonoBehaviour
{
    public Canvas MainMenu;
    void Start()
    {
        // Switch to 640 x 480 full-screen
        Screen.SetResolution(3840, 2160, true);
    }

    public void StartGame()
    {


        SceneManager.LoadScene("saved4");
    }

    public void QuitGame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }



}